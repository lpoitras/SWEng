
#include "items.h"



items::items(QWidget *parent)

    : QGraphicsView(parent)
{
    scene = new QGraphicsScene(0, 0, 690, 270);
    this->setScene(scene);
    index = 0;
}

void items::mousePressEvent(QMouseEvent *event)
{
    QGraphicsItem* ItemUnderMouse = itemAt(event->pos().x(), event->pos().y());
       if (!ItemUnderMouse)
           return;
       int kk = event->pos().x() / 30;
       ItemUnderMouse->setVisible(false);
       arr[index] = kk - 1;
       index++;
}

void items::addItems(int a[])
{
    index = 0;
    for (int i = 0; i < 5; i++)
    {
        QGraphicsTextItem *it = new QGraphicsTextItem(QString::number(a[i]));
        it->setX(130 * (i + 1));
        it->setY(150);
        scene->addItem(it);
    }
}
