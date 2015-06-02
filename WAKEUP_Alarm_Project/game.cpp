#include "game.h"
#include "ui_game.h"
#include <QBitmap>
#include <QLabel>
Game::Game(QWidget *parent) :

    QMainWindow(parent),
    ui(new Ui::Game)
{
    ui->setupUi(this);
    it = new items(ui->graphicsView);
    arr=new int [5];
    sarr=new int [5];
    int kk = ui->tabWidget->currentIndex();
    if (kk == 0)Game1();
    if (kk == 1)Game2();
    if (kk == 2)Game3();
    alarmcheck=0;
    checking=0;

}

Game::~Game()
{
    delete ui;
}

void Game::sort_array (int arr1[], int size)
{
    int temp;
    for(int i = 0; i <size; i++)
    {

        for (int j = 0; j <size-1; j++)
        {
            if (arr1[j] > arr1[j+1])
            {
                temp = arr1[j];
                arr1[j] = arr1[j+1];
                arr1[j+1] = temp;
            }
        }
    }
}

bool Game::if_skipped ()
{
    //if different_question button pressed
    return false;
}

int Game::factorial(int x, int result)
{
    if (x < 0) return 0;
    if (x == 1) return result;
    return factorial(x - 1, x * result);
}


void Game::Game1()
{
    //Game 1.....
   // map<char,int> mymap0;

    int i=0;
     ui->Answer_label->setVisible(false);
      ui->label_2->setAlignment(Qt::AlignCenter);
      ui->label_3->setAlignment(Qt::AlignCenter);
       ui->label_4-> setAlignment(Qt::AlignCenter);
       ui->Answer_label-> setAlignment(Qt::AlignCenter);
      //ui->alarm_status->setVisible(false);
        int k= rand()%6+1;
        int l= rand()%10+1;
        param=k;
       // mymap0['Sun']=10;
       // mymap0['Mars']=7;

        //sum1=(1+k)*10;
        //sum2=(1+l)*7;
        ui->pushButton_3->setVisible(true);
        ui->pushButton_2->setVisible(true);
        ui->pushButton->setVisible(true);
        switch (k){
        case (1):{
            ui->label_2->setText(" What is heavier? ");
            ui->pushButton_2->setText("Equal");
            if (l!=1){
                ui->label_4->setText(QString::number(l) + " pounds of rocks");
                ui->label_3->setText(QString::number(l) + " pounds of plumage");}
            else {
                ui->label_4->setText(QString::number(l) + " pound of rocks");
                ui->label_3->setText(QString::number(l) + " pound of plumage");}

            break;}
        case (2):{
             ui->label_2->setText("Does Britain have a 4th of July?");
                ui->label_4->setText("No! It is an American Holiday");
                ui->label_3->setText(" Yes");
        break;}
        case (3):{
               ui->label_2->setText("How can a man go eight days without sleep? ");
               ui->label_4->setText("No! No one can do that");
               ui->label_3->setText(" Yes! He is an engineering student. He can do everything!");
        break;}
        case (4):{
               ui->label_2->setText("How much dirt is there in a hole 3*6*4? ");
               ui->label_4->setText("None");
               ui->label_3->setText("72!");
        break;}
        case (5):{
               ui->label_2->setText("Divide 50 by half and add 20.");
               ui->label_3->setText("120");
               ui->label_4->setText("45");
        break;}
        case (6):{
               ui->label_2->setText("What is in the middle of CHINA?");
               ui->label_3->setText("I");
               ui->label_4->setText("Beijing");
        break;}
        case (7):{
            ui->pushButton_2->setText("I don't know!");
               ui->label_2->setText("What is the capital of America");
               ui->label_3->setText("New York");
               ui->label_4->setText("Washington DC");
        break;}

        }

}



int Game::Game1Check()
{   QMessageBox msgBox;
    msgBox.setWindowTitle("Result");
    msgBox.setStandardButtons(QMessageBox::Yes);
    //ui->label->setText(QString::number(param) + " * " + QString::number(answer));
    switch (param)
    {
    case (1):{
        if((answer==0)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
             //ui->alarm_status->setVisible(true);
             ui->Answer_label->setText(" A POUND VS ANOTHER POUND!");
             ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");alarmcheck=1;
        }
        else {
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText(" A POUND VS ANOTHER POUND!");
            ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
            msgBox.setText("Incorrect");}
        break;}

    case (2):{
        if((answer==1)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
             //ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("Yes they do, and a July 5th and a July 6th!!");
             ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");alarmcheck=1;}


        else if (answer==2) { ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
             //ui->alarm_status->setVisible(true);
            ui->Answer_label->setText("Yes they do, and a July 5th and a July 6th!!");
            ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
            msgBox.setText("Incorrect");
        }
        else{
             ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
              msgBox.setText("Alarm will keep playing this awesome melody FOREVER!");
        }

    break;}
    case (3):{
        if((answer==1)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("Yeah, maybe he just sleeps at night! ");
            ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");alarmcheck=1;}



        else if (answer==2){ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("Maybe he just sleeps at night! ");
            ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
            msgBox.setText("Incorrect");


        }
        else {

             ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
              msgBox.setText("Alarm will keep playing this awesome melody FOREVER!");
        }


    break;}
    case (4):{
        if((answer==1)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("You are right, it is still a hole!");
            ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");alarmcheck=1;
            }
        else if (answer==2){
            ui->pushButton_3->setVisible(false);
                        ui->pushButton_2->setVisible(false);
                        ui->pushButton->setVisible(false);
                        ui->Answer_label->setVisible(true);
                        // ui->alarm_status->setVisible(true);
                         ui->Answer_label->setText("!!!!!!!!!IT IS A HOLE!!!");
                        ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
                        msgBox.setText("Incorrect");
                        }
        else{
             ui->pushButton_6->setText("HAHAHAHHA! NOOOOOOO! Play again!");
              msgBox.setText("Alarm will keep playing this awesome melody FOREVER!");
        }

    break;}

    case (5):{
        if((answer==2)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("Good Job! Now get up!)");
            ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");alarmcheck=1;


          }
        else if((answer==1)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("!!!!!!!!!!!!50/0.5+20!!!!!!!!!!!!!!!");
            ui->pushButton_6->setText("HAHAHAHHA!Play again!");
            msgBox.setText("Incorrect");

        }
        else{

            ui->pushButton_6->setText("HAHAHAHHA!Play again!");
             msgBox.setText("Alarm will keep playing this awesome melody FOREVER!");
        }
    break;}
    case (6):{
        if((answer==2)){

                ui->pushButton_3->setVisible(false);
                ui->pushButton_2->setVisible(false);
                ui->pushButton->setVisible(false);
                ui->Answer_label->setVisible(true);
                // ui->alarm_status->setVisible(true);
                 ui->Answer_label->setText("You are smart! Have a nice day!");
                ui->pushButton_6->setText("Congrats! You can turn me off!");
                msgBox.setText("Correct");
                alarmcheck=1;
                //msgBox.exec();
           }
        else if((answer==1)){
                ui->pushButton_3->setVisible(false);
                ui->pushButton_2->setVisible(false);
                ui->pushButton->setVisible(false);
                ui->Answer_label->setVisible(true);
                // ui->alarm_status->setVisible(true);
                 ui->Answer_label->setText("Look CAREFULLY! Beijing is not located at the center");
                ui->pushButton_6->setText("HAHAHAHHA!Play again!");
                msgBox.setText("Incorrect");
        //msgBox.exec();}
        }
        else{
             ui->pushButton_6->setText("HAHAHAHHA!Play again!");
               msgBox.setText("Alarm will keep playing this awesome melody FOREVER!");
        }

    break;}
    case (7):{
        if((answer==2)){
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
              ui->Answer_label->setText("America is not USA, technically)");
            ui->pushButton_6->setText("Congrats! You can turn me off!");
            msgBox.setText("Correct");
            alarmcheck=1;}
        else  {
            ui->pushButton_3->setVisible(false);
            ui->pushButton_2->setVisible(false);
            ui->pushButton->setVisible(false);
            ui->Answer_label->setVisible(true);
            // ui->alarm_status->setVisible(true);
             ui->Answer_label->setText("America is not USA, technically)");
            ui->pushButton_6->setText("HAHAHAHHA!Play again!");
            msgBox.setText("Incorrect");}

    break;}

    }

   msgBox.exec();
   return alarmcheck;




}

void Game::Game2()
{
    //Game2______MATH PROBLEMS!!!!!!!!!!!!!!!!!!!!!!!BEGIN
    //random numbers up to 100
    ui->label_6->setAlignment(Qt::AlignCenter);
    ui->label_5->setAlignment(Qt::AlignCenter);
     ui->label_7-> setAlignment(Qt::AlignCenter);
    srand((unsigned)time(0));
    number1 = rand()%100;
    number2 = rand()%100;
    number3 = rand()%100;

     map<char,int> mymap;
     mymap['-']=0;
     mymap['+']=1;
     mymap['!']=2;
     mymap['*']=3;

     answer2 = 0;
     n=rand()%4;

         switch(n)
         {
         case (0):
         {
             answer2 = number1-number2+number3;
             ui->label_6->setText(QString::number(number1) + " - " + QString::number(number2) + " + " + QString::number(number3));
             break;
         }
         case(1):
         {
             int number4=rand()%5;
             answer2=number1+number2+factorial(number4,1);
             ui->label_6->setText(QString::number(number1) + " + " + QString::number(number2) + " + " + QString::number(number4) + "!");
             break;
         }
         case(2):
         {
             int number4=rand()%5+1;
             answer2=factorial(number4,1)-number1;
             ui->label_6->setText(QString::number(number4) + "!" + " - " + QString::number(number1));
             break;
         }
         case(3):
         {
             int m=(rand()%2);
             answer2=number1*m+number2;
             ui->label_6->setText(QString::number(number1) + " * " + QString::number(m) + " + " + QString::number(number2));
             break;
         }
         }

}

void Game::Game2Check()
{
    int userAnswer = ui->lineEdit->text().toInt();

    QMessageBox msgBox;
    msgBox.setWindowTitle("Result");
    msgBox.setStandardButtons(QMessageBox::Yes);

    if (userAnswer==answer2)
    {msgBox.setText("Correct!");alarmcheck=1;}
    else
        msgBox.setText("Incorrect!");

    msgBox.exec();
}

void Game::Game3()
{
    //Game3____BUBBLES

        int size=5;

        int element;
        int clone [5];
        int d;

        //fill array
        for (int i = 0; i <size; i ++)
        {
           element= rand() % 10000+ 1;
           arr[i] = element;
           sarr[i] = element;
        }

        it->addItems(arr);

        sort_array(sarr, size);
       //  ui->order->setText(QString::number(checking) );
}

void Game::on_tabWidget_currentChanged(int index)
{
    if (index == 0) Game1();
    if (index == 1) Game2();
    if (index == 2) Game3();
}

void Game::on_pushButton_2_clicked()
{
    answer = 0;
    Game1();
   // Game1Check();

    int flag=Game1Check();
    //if (flag==1){Game1();}
}
void Game::on_pushButton_clicked(){
    answer=1;
    //Game1();

    int flag=Game1Check();
    //if (flag==1){Game1();}

}
void Game::on_pushButton_3_clicked(){
    answer=2;

    int flag=Game1Check();





}
void Game::on_pushButton_4_clicked()
{
    Game2Check();
    if (alarmcheck==0){ ui->lineEdit->setText("");}
    Game2();
}

void Game::on_pushButton_5_clicked()
{
    QMessageBox msgBox;
    msgBox.setWindowTitle("Result");
    msgBox.setStandardButtons(QMessageBox::Yes);
//ui->order->setText(QString::number(checking));

    for (int i = 0; i < 5; i++)
    {
        if (arr[it->arr[i]]!=sarr[i]) {checking=5;

        }

        //if (arr[it->arr[i]]!=sarr[i]) {checking=1;}
        //ui->order->setText(QString::number(sarr[i]));

    }

  //ui->order->setText((QString::number(sarr[4])+"+"+QString::number(sarr[3])"+"+QString::number(sarr[2])+"+"+QString::number(sarr[1])+"+"+QString::number(sarr[0])));

    if (checking!=5)
    {msgBox.setText("Correct!");alarmcheck=1;}
    else
    {msgBox.setText("Incorrect!");}


    msgBox.exec();
    if (alarmcheck==1){ui->pushButton_6->setText("Congrats! You can turn me off!");}
    else{Game3();}



}

void Game::on_pushButton_6_clicked(){

    QMessageBox msgBox;
    msgBox.setWindowTitle("Alarm");
    msgBox.setStandardButtons(QMessageBox::Yes);

    if (alarmcheck==1){
        msgBox.setText("Good Morning!");
        QCoreApplication::exit();
    }
    else{
        Game1();
        msgBox.setText("You need to win one of the Games first!");
    }


    msgBox.exec();

}
 int Game::alarm_stat() {

    return alarmcheck;
}
