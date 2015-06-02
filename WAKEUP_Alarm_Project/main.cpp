#include "mainwindow.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;
    w.show();
    
    QString currentTime = QTime::currentTime().toString("hh:mm");
    
    
    //    player.setMedia(QUrl::fromLocalFile("/Users/lukepoitras/Desktop/cae.mp3"));
    //    player.setVolume(100);
    //    player.play();
    
    
    return a.exec();
}
