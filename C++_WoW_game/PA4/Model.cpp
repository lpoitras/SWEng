
//
//  Model.cpp
//  PA4
//
//  Created by Luke Poitras on 5/1/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#include "Model.h"
#include "Person.h" 
#include "Miner.h"
#include "C_Point.h"
#include "Game_Object.h"
#include "Warrior.h"

// Model is like the framework in program for all objects

Model::Model()
{
    time = 0;
    
    Person *miner1;
    miner1 = new Miner(1, C_Point(5,1));
    this->object_ptrs[0] = miner1;
    this->person_ptrs[0]= miner1;
    
    Person *miner2;
    miner2 = new Miner(2, C_Point(10,1));
    object_ptrs[1] = miner2;
    person_ptrs[1] = miner2;
    
    Candy_Mine *c1;
    c1 = new Candy_Mine(1, C_Point(1,20));
    object_ptrs[2] = c1;
    mine_ptrs[0] = c1;
    
    Candy_Mine *c2;
    c2 = new Candy_Mine(2, C_Point(10, 20));
    object_ptrs[3] = c2;
    mine_ptrs[1] = c2;
    
    Tower *t;
    t = new Tower(0,C_Point());
    object_ptrs[4] = t;
    tower_ptrs[0] = t;
    
    Person *w3;
    w3 = new Warrior(3, C_Point(5,15));
    object_ptrs[5] = w3;
    person_ptrs[2] = w3;
    
    Person *w4;
    w4 = new Warrior(4, C_Point(10,15));
    object_ptrs[6] = w4;
    person_ptrs[3] = w4;

    
    num_objects = 7;
    num_persons = 4;
    num_mines = 2;
    num_towers = 1;
    
    std::cout << "Model default constructed" << std::endl;
}


Person * Model::get_Person_ptr(int id)
{
    for (int i = 0; i < num_objects; i++)
    {
        if (object_ptrs[i] != nullptr)
            if (object_ptrs[i] -> get_id() == id)
                return person_ptrs[id-1];
    }
    return 0;
}

Candy_Mine * Model::get_Candy_Mine_ptr(int id)
{
    for (int i = 0; i < num_objects; i++)
    {
        if (object_ptrs[i] != nullptr)
            if (object_ptrs[i]->get_id() == id)
                return mine_ptrs[id-1];
    }
    return 0;
}

Tower * Model::get_Tower_ptr(int id)
{
//    return tower_ptrs[id-1];
    
    for (int i = 0; i < num_objects; i++)
    {
        if (object_ptrs[i] != nullptr)
            if (object_ptrs[i] -> get_id() == id)
                return tower_ptrs[id-1];
    }
    return 0;

}

bool Model::update()
{
    time++;
    bool flag = 0;
    
    for (int i = 0; i < num_objects; i++)
    {
        if(object_ptrs[i]->update())
         {
             flag = 1;
         }
    }
    return flag;
}

void Model::display(View &view)
{
    
    std::cout << "Time: " << time <<std::endl;
    view.clear();
    for (int i = 0; i < num_objects; i++)
    {
        if(object_ptrs[i]->is_alive() == 0)
        {
            break;
        }
        else
        {
            view.plot(object_ptrs[i]);
        }

    }
    view.draw();
    
}

void Model::show_status()
{
    for (int i = 0; i < num_objects; i++)
    {
        object_ptrs[i]->show_status();
    }
}

Model::~Model()
{
    for (int i = 0; i < 7; i++)
    {
        delete object_ptrs[i];
    }
    std::cout<<"Model destructed.\n";
}


        





