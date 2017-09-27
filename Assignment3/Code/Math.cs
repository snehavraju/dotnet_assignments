using System;
namespace Code{
public class math {
    TrianglePerimeter tp = new TrianglePerimeter();
    RectanglePerimeter rp = new RectanglePerimeter();
    SquarePerimeter sp = new SquarePerimeter();


    public math (int side1, int side2, int side3){
        tp.Side1=side1;
        tp.Side2=side2;
        tp.Side3=side2;
    }

    public math (int length,int breadth){
        rp.Length=length;
        rp.Breadth=breadth;
    }

    public math (int side){
        sp.Side=side;
    
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