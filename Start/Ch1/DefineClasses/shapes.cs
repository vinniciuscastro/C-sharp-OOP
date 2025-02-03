// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle {

    // TODO: The constructor accepts parameters used to create the object
    public Rectangle(int width, int height) {
        w = width;
        h = height;
    }


    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side) {
        w = side;
        h = side;
    }


    // TODO: Classes can define methods that return values
    public int getArea() {
        return w * h;
    }

    public int Width {
        get { return w; }
        set { w = value; }
    }
    public int Height {
        get { return h; }
        set { 
            if (value < 0) {
                throw new ArgumentOutOfRangeException("Height must be non-negative");
            }
            h = value;
        }
    }

    public int BorderSize { 
        get; set;

        } = 1;

    // TODO: member variables hold data
    int w;
    int h;
    
}
