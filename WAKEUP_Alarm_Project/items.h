#ifndef ITEMS_H
#define ITEMS_H

#include <QGraphicsView>
#include <QGraphicsScene>
#include <QGraphicsTextItem>
#include <QGraphicsItem>
#include <QMouseEvent>

class items: public QGraphicsView
{
     Q_OBJECT

public:
    items(QWidget *parent = 0);
    QGraphicsScene *scene;
    int arr[5];
    int index;


protected:
    void mousePressEvent(QMouseEvent *event);

public slots:
    void addItems(int a[5]);
};

#endif // ITEMS_H
