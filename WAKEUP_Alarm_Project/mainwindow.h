
#ifndef MAINWINDOW_H
#define MAINWINDOW_H
#include <QtOpenGL>
#include <QMainWindow>
#include <QMediaPlayer>
#include <QDateTimeEdit>
#include <QMessageBox>
#include <QCheckBox>
#include <QtGui>
#include <game.h>
namespace Ui {
    class QCheckBox;
    class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT
    
public:

    explicit MainWindow(QWidget *parent = 0);
    QTime *newTime;
    ~MainWindow();

    void o();

   // Game *mygame;
    //    void setAlarm();
    void playAlarm(QTime &newTime);
    void switch_to_game();

private slots:
    QTime on_timeEdit_timeChanged(const QTime &time);
    void showTime();
    void on_setAlarm_clicked();
    void on_cancelAlarm_clicked();
    void on_checkBox_clicked();



private:
    Ui::MainWindow *ui;
    
    
    
    
};

#endif // MAINWINDOW_H
