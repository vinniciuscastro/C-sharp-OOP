// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static methods

public class Temperature {
    // constant values don't need to be defined as static, it is implied
    public const double ROOM_TEMP_LOWER_C = 20.0;
    public const double ROOM_TEMP_UPPER_C = 23.0;

    public Temperature(double t) {
        Temp = t;
    }

    // TODO: static methods use the 'static' modifier in their declaration
    public static double FtoC(double Ftemp) {
        double Ctemp = (Ftemp - 32.0) * (5.0 / 9.0);
        return Ctemp;
    }

    public static double CtoF(double Ctemp) {
        double Ftemp = (Ctemp * (9.0 / 5.0)) + 32.0;
        return Ftemp;
    }

    // Regular property implementation
    public double Temp { get; set; }

    // TODO: You can overload methods and have one of them be static. This doesn't work with properties
    public bool IsRoomTemp() {
        return Temp >= ROOM_TEMP_LOWER_C && Temp <= ROOM_TEMP_UPPER_C;
    }

    public static bool IsRoomTemp(double temp) {
        return temp >= ROOM_TEMP_LOWER_C && temp <= ROOM_TEMP_UPPER_C;
    }

    // This does not work - will cause a compile error
    // public bool IsRoomTemp {
    //     get => Temp >= ROOM_TEMP_LOWER_C && Temp <= ROOM_TEMP_UPPER_C;
    // }
}
