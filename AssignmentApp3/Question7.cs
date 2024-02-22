using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace AssignmentApp3;

public class Color{
    public int Red{get;set;}
    public int Green{get;set;}
    public int Blue{get;set;}
    public int Alpha{get;set;}
    public Color(int red, int green, int blue, int alpha=255){
        Red = red;
        Green = green;
        Blue = blue;
        Alpha = alpha;

    }
    public int GetGrayScale(){
        return (Red+Green+Blue)/3;
    }    
    
}
public class Ball{
    double Size{get;set;}
    Color ColorOfBall{get;set;}

    int Times{get;set;}

    public Ball(double size, Color color, int times=0){
        Size=size;
        ColorOfBall =color;
        Times=times; 
    }
    public void Pop(){
        Size=0;
    }
    public void Throw(){
        if(Size!=0){
            Times++;
        }
    }
    public int GetTimes(){
        return Times;
    }
}
