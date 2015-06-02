//
//  Warrior.cpp
//  PA4
//
//  Created by Luke Poitras on 5/2/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#include "Warrior.h"
#include "Person.h"
#include "C_Point.h"
#include "Game_Object.h"

// A warrior is a type of person

Warrior::Warrior()
{
    attack_strength = 2;
    range = 2.0;
  
    std::cout << "Warrior default constructed" << std::endl;
};

Warrior::Warrior(int in_id, C_Point in_loc) : Person('W', in_id, in_loc)
{
    attack_strength = 2;
    range = 2.0;
    target = NULL;
    std::cout << "Warrior constructed" << std::endl;
    
}

// Attack function of warrior
void Warrior::start_attack(Person * in_target)
{
    while(this->is_alive() == true)
    {
    
    target = in_target;
    double attack_dist;
    
    setup_destination(target->get_location());
    C_Point tLoc = target->get_location();

    attack_dist = C_distance(tLoc, location);
    if (attack_dist <= range)
    {
        std::cout << display_code << get_id()<< ": Attacking" << std::endl;
        state = 'a';
        Warrior::update();
    }
    else
    {
        std::cout<< display_code << get_id()<< ": Target is out of range"<<std::endl;
    }
        break;
    }
    if(this->is_alive() == false)
       {
           std::cout << display_code << get_id()<< ": I am dead. You do not have the ability to summon the undead. \n";
       }
}

bool Warrior::update()
{
    switch (state)
    {
        case 'm':
        {
            if(update_location() == true)
            {
                state = 's';
                return true;
            }
            else
            {
                return false;
                break;
            }
        case 'x': // state of being dead
        {
            return false;
            break;
        }
        case 's':
        {
            return false;
            break;
        }
        case 'a':
        {
            double dist;
            C_Point tLoc = target->get_location();
            
            dist = C_distance(tLoc, this->location);
//            std::cout  << display_code << get_id() << ": I will hit you unless you move away! \n";
//            
//            If the warrior is too far from their target
            if (dist > range)
            {
                std::cout << "Out of range. \n";
                state = 's';
                return true;
            }
            else
            {
                if((target->is_alive() == true))
                {
                    std::cout << display_code <<get_id() << ": Clang! \n";
                    
                    target->take_hit(attack_strength);
                    return false;
                }
                else
                {
                    std::cout << display_code<< get_id() << ": I triumph! \n";
                    state = 's';
                    return true;
                }
                break;
            }
        }
        default:
            break;
    }
    
    }
    return false;
}
void Warrior::show_status()
{
    std::cout << "Warrior status: ";
    Person::show_status();
    if (state == 'a')
    {
        std::cout << "      Attacking." << std::endl;
    }

}
