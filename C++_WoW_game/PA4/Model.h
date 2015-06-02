//
//  Model.h
//  PA4
//
//  Created by Luke Poitras on 5/1/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#ifndef __PA4__Model__
#define __PA4__Model__

#include <iostream>
#include "Game_Object.h"
#include "Person.h"
#include "Candy_Mine.h"
#include "Tower.h"
#include "View.h"
#include "Miner.h"
#include "C_Point.h"
#include "Warrior.h"


class Model
{
private:
//    Model(Model & mod);
    int time;
    Game_Object * object_ptrs[10];
    int num_objects;
    Person * person_ptrs[10];
    int num_persons;
    Candy_Mine * mine_ptrs[10];
    int num_mines;
    Tower * tower_ptrs[10];
    int num_towers;

public:
    Model();
    virtual ~Model();
    bool update();
    void display(View &view);
    void show_status();
    Person * get_Person_ptr(int);
    Candy_Mine * get_Candy_Mine_ptr(int);
    Tower * get_Tower_ptr(int);
    
    
};



#endif /* defined(__PA4__Model__) */
