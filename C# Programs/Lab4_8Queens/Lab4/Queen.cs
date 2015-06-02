using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Lab4
{

 public class Queen
    {
     int r, c;
     int occupied;
     public bool[,] qArray;

     public Queen()
        {
            //r = 0;
            //c = 0;
        }
     public Queen(int Row, int Col, int o)
     {
         
         r = Row;
         c = Col;
         //row = (r-100)/50;
         //col = (c-100)/50;
         //Occupied = o;
      //   bool[,] qArray = new bool[8, 8];
       //  qArray[r, c] =true;

         //for (int i = 0; i <= 8; i++)
         //{
         //    for (int j = 0; j <=8; j++)
         //    {
         //        qArray[r, c] = true;
         //    }
         //}

         
     }
     public int Row
     {
         get
         { 
             return r;
         }
         set
         {
             r = value;
         }
     }
     public int Col
     {
         get
         {
             return c;
         }
         set
         {
             c = value;
         }
     }
     public int Occupied
     {
         get { return occupied; }
         set { occupied = value; }
     }

    }

    }

