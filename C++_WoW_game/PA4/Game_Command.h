//
//  Game_Command.h
//  PA4
//
//  Created by Luke Poitras on 5/1/14.
//  Copyright (c) 2014 PA4. All rights reserved.
//

#ifndef __PA4__Game_Command__
#define __PA4__Game_Command__

#include <iostream>
#include "Model.h"
#include "Miner.h"



    
    void do_move_command(Model& model);
    void do_work_command(Model& model);
    void do_attack_command(Model& model);
    void do_stop_command(Model& model);
    void do_go_command(Model& model);
    void do_run_command(Model& model);
    void do_list_command(Model& model);






#endif /* defined(__PA4__Game_Command__) */
