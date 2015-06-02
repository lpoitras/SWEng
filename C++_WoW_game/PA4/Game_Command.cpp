
//
//  Game_Command.cpp
//  PA4
//
//  Created by Luke Poitras on 5/1/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#include "Game_Command.h"
#include "Model.h"
#include "Person.h"
#include "View.h"
#include "Game_Object.h"
#include "Miner.h"

// Game_Command takes over control of all commands from main function

void do_move_command(Model& model)
{
    Person *p1;
    int id = 0;
    double x = 0;
    int y = 0;
    
    std::cin >> id >> x >> y;
    
    if((id==1)||(id==2)||(id==3)||(id==4))
    {
        View v1;
        C_Point loc = C_Point(x,y);
        p1 = model.get_Person_ptr(id);
        p1->start_moving(loc);
       
    }
    else
    {
        std::cout<<"Please enter a valid id" <<std::endl;
    }
}
void do_work_command(Model& model)
{
    int id = 0;
    int cId = 0;
    int tId = 0;
    std::cin >> id >> cId >> tId;

    Miner * m ;
    Candy_Mine *candyId;
    Tower *towerId;
   
    
    if((id==1)||(id==2)||(id==3)||(id==4))
    {
        
        m = (Miner *) model.get_Person_ptr(id);
        candyId = model.get_Candy_Mine_ptr(cId);
        towerId = model.get_Tower_ptr(tId);
        m->start_mining(candyId, towerId);
        
//        model.update();
       
    }
//    else
//    {
//       std::cout << "
//    }

}
void do_attack_command(Model& model)
{
    int id1 = 0;
    int id2 = 0;
 
    
    std::cin >> id1 >> id2;
    
    if(id1 <= 4 && id2 <= 4)
    {
        Person *p1;
        Person *p2;
        
        p1 = model.get_Person_ptr(id1);
        p2 = model.get_Person_ptr(id2);
        
        p1 ->start_attack(p2);
        //        model.update();
    }
}
void do_stop_command(Model& model)
{
    int id;
    Person *stop;
    
    std::cin >> id;
    if(!std::cin)
    {
        std::cout << "ERROR! Enter a valid command and miner ID: ";
        std::cin.clear();
        std::cin.ignore();

    }
    else
    {
        stop = model.get_Person_ptr(id);
        stop->stop();
    }

}
void do_go_command(Model& model)
{
//    std::cout << "Advancing one tick. \n";
    
//    View *vg;
    model.update();
//    model.show_status();
//    model.display(*vg);
}



void do_run_command(Model& model)
{
//    std::cout << "Advancing to next event.\n";

    
    int step = 0;
    while (1)
    {
        step++;
       
        if (model.update() == true)
        {
          
            break;
        }
        if (step == 5)
        {
            break;
        }
    }
}

// Calling list can only show status' now
void do_list_command(Model& model)
{
    
   model.show_status();
    
}