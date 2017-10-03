using System;
namespace Code{
public class math {
    TrianglePerimeter tp = new TrianglePerimeter();
    RectanglePerimeter rp = new RectanglePerimeter();
    SquarePerimeter sp = new SquarePerimeter();


    public math (int side1, int side2, int side3){
        if(side1<=0){
            throw new Exception("Sides should be a positive number");
        }
        else
        {tp.Side1=side1;}
        if(side2<=0){
            throw new Exception("Sides should be a positive number");
        }
        else{
        tp.Side2=side2;
        }
        if(side3<=0){
            throw new Exception("Sides should be a positive number");
        }
        else
        {
        tp.Side3=side2;}
    }

    public math (int length,int breadth){
        if(length<=0){
            throw new Exception("Side should be a positive number");
        }else{
        rp.Length=length;
        }
        if(breadth<=0){
            throw new Exception("Side should be a positive number");
        }
        else{
        rp.Breadth=breadth;
        }
    }

    public math (int side){
        if(side<=0){
            throw new Exception("Side should be a positive number");
        }
        else{
        sp.Side=side;
        }
    }
    public int squareperim ()
    {   int perim= 4*(sp.Side);
        
        return (perim);
    }

     public int rectangleperim ()
    {   int perim= 2*(rp.Length+rp.Breadth);
        
        return (perim);
    }

     public int triangleperim ()
    {   int perim=(tp.Side1+tp.Side2+tp.Side3);
        
        return (perim);
    }
   
   
   

   

   
}}