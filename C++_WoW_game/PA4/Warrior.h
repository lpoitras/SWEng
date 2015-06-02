//
//  Warrior.h
//  PA4
//
//  Created by Luke Poitras on 5/2/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#ifndef __PA4__Warrior__
#define __PA4__Warrior__

#include <iostream>
#include "Person.h"
#include "C_Point.h"
#include "Game_Object.h"


class Warrior : public Person
{
public:
    Warrior();
    Warrior(int in_id, const C_Point in_loc);

    void start_attack(Person * in_target);
    bool update();
    void show_status();
    
    
private:
    int attack_strength;
    double range;
    Person * target;
    
};
















#endif /* defined(__PA4__Warrior__) */
