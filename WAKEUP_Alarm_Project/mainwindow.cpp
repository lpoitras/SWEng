#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "game.h"
#include <QTimer>
#include <QDateTime>
#include <QDateTimeEdit>
#include <QTimeEdit>
#include <QDateEdit>
#include <QMediaPlayer>
#include <QCheckBox>
#include <QApplication>
#include <QtCore>
#include <QtGui>
#include <QThread>
 #include <QTreeView>

MainWindow::MainWindow(QWidget *parent) :
QMainWindow(parent),
ui(new Ui::MainWindow)
{//ui->checkBox->setHidden(false);
//    ui->checkBox_2->setHidden(true);
    ui->setupUi(this);
 ui->label->setVisible(false);
     ui->cancelAlarm->setVisible(false);
//ui->on_setAlarm_clicked()->;
ui->checkBox->setChecked(false);
    ui->checkBox->setHidden(true);

    QTimer *timer = new QTimer(this);
    connect(timer, SIGNAL(timeout()), this, SLOT(showTime()));
    timer->start();

//    QTimer *timer2 = new QTimer(this);
//    connect(timer2, SIGNAL(timeout()), this, SLOT(on_checkBox_clicked()));
//    timer2->start(1000);
   showTime();
    ui->timeEdit->setTime(QTime::currentTime());
    ui->dateEdit->setDate(QDate::currentDate());
}

void MainWindow::showTime()
{
    QTime time = QTime::currentTime();
//    QString currentTime = QString::number(QTime::currentTime().hour()) + QString::number(QTime::currentTime().minute());
    QString time_text = time.toString("hh : mm");

    if((time.second() % 2) == 0)
    {
        time_text[4] = ' ';
    }
    ui->Digital_Clock->setText(time_text);
}

void MainWindow::on_setAlarm_clicked()
{
    ui->cancelAlarm->setVisible(true);
ui->label->setVisible(true);
   // if(this->ui->checkBox->isChecked())
       // {
            ui->label2->setText("Alarm set");
            QString alarmTime;
            QString currentTime;
            on_checkBox_clicked();
              QTimer *timer2 = new QTimer(this);
               connect(timer2, SIGNAL(timeout()), this, SLOT(on_checkBox_clicked()));
               timer2->start(11000);

    //    else
    //    {
    //        ui->label2->setText("");
    //    }
    //}

}

void MainWindow::switch_to_game(){

}




MainWindow::~MainWindow()
{
    delete ui;
}


QTime MainWindow::on_timeEdit_timeChanged(const QTime &time)
{
    QTime newTime = time;
    QString time_text = newTime.toString("hh : mm");
    
    ui->label->setText(time_text);
    
    return newTime;
}
void MainWindow::playAlarm(QTime &newTime)
{
    
}

void MainWindow::on_checkBox_clicked()
{

        QMediaPlayer *player = new QMediaPlayer(this);
        player->setMedia(QUrl::fromLocalFile("/Users/lukepoitras/Desktop/understanding.mp3")); // EDIT THIS LINE TO LOCAL FILE PATH
        player->setVolume(100);


       QString alarmTime = QString::number(this->ui->timeEdit->time().hour()) + QString::number(this->ui->timeEdit->time().minute());
       QString currentTime = QString::number(QTime::currentTime().hour()) + QString::number(QTime::currentTime().minute());

    //int flag_al=0;
  if (currentTime>=alarmTime)
        {
            player->play();
             this->hide();
            Game *mygame= new Game();
            this->close();
            mygame->show();
            if (mygame->alarm_stat()==1){
                mygame->close();
                player->stop();


            }}



}



void MainWindow::on_cancelAlarm_clicked()
{    ui->cancelAlarm->setVisible(false);
     ui->setAlarm->setVisible(true);
     //ui->on_setAlarm_clicked()->;
     ui->checkBox->setChecked(false);
      ui->label->setText(" ");
       ui->label2->setVisible(false);

    //    ui->setAlarm->setVisible(false);
}






