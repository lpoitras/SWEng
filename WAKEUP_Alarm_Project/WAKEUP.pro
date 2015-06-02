#-------------------------------------------------
#
# Project created by QtCreator 2014-05-11T19:58:07
#
#-------------------------------------------------

QT += core gui multimedia
QT += opengl
CONFIG += mobility
QT += multimedia

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = WAKEUP
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    game.cpp \
    items.cpp

HEADERS  += mainwindow.h \
    items.h \
    game.h

FORMS    += mainwindow.ui \
    game.ui
