public double Procedural_Area(string  shape) throws NoSuchShapeException
{
    if(shape=="Square"){
        return getAreaOfSquare();
    }
    else if(shape=="Circle"){
        return getAreaOfCircle();
    }
    throw new NoSuchShapeException
}


public double Still_Procedural_Area_objects(Object shape) throws NoSuchShapeException
{
    if(shape instanceof Square){
        return getAreaOfSquare();
    }
    else if(shape instanceof Circle){
        return getAreaOfCircle();
    }
    throw new NoSuchShapeException
}

public class Square{
    public Point topLeft;
}