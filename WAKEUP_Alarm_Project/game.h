#ifndef GAME_H
#define GAME_H

#include <QMainWindow>
#include <ctime>
#include <iostream>
#include <cmath>
#include <cstdlib>
#include <map>
#include <QMessageBox>
#include <QGraphicsScene>
#include <QGraphicsItem>
#include "items.h"
#include "mainwindow.h"
 #include <QTreeView>

using namespace std;

namespace Ui {
class Game;
}

class Game : public QMainWindow
{
    Q_OBJECT

public:
    explicit Game(QWidget *parent = 0);
    int alarm_stat() ;

    ~Game();

private slots:
    void on_tabWidget_currentChanged(int index);

    void on_pushButton_2_clicked();

    void on_pushButton_4_clicked();

    void on_pushButton_5_clicked();
    void on_pushButton_6_clicked();
    void on_pushButton_clicked();
    void on_pushButton_3_clicked();

private:
    Ui::Game *ui;
    void sort_array (int arr1[], int size);
    bool if_skipped ();
    int factorial(int x, int result);
    void Game1();
    void Game2();
    void Game3();
    int Game1Check();
    void Game2Check();
    void Game3Check();
    int answer, answer2;
    int sum1,sum2;
    int number1, number2, number3;
    int k;
    int alarmcheck;
    int param;
    int n;
    int *arr, *sarr;
    int checking;
    items *it;


};

#endif // GAME_H
