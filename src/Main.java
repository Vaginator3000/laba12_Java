import java.io.IOException;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.Scanner;

interface ICloneable  extends Cloneable {
    Object DeepClone();
    //  Object ShallowClone();
}

interface Veh extends ICloneable {
        void Buy();
        void Drive();
        }

class Auto implements Veh {
    protected String brand; //марка
    protected int power; //мощность
    protected int cost;     //стоимость

    public Auto() {
        brand = "";
        power = 0;
        cost = 0;
    }

    public Auto(String brand, int power, int cost) {
        this.brand = brand;
        this.cost = cost;
        this.power = power;
    }

    public void Drive() {
        System.out.println("Человек едет на " +brand);
    }

    public void Buy() {
        System.out.println("Человек купил " +brand);
    }

    public void display() {
        System.out.println(brand + ", " + power + "л.с. - " + cost + "p");
    }

    public void read() {
        try {
            BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
            System.out.println("Марка: ");
            brand = reader.readLine();
            System.out.println("Мощность: ");
            power = Integer.parseInt(reader.readLine());
            System.out.println("Стоимость: ");
            cost = Integer.parseInt(reader.readLine());
        } catch(Exception e) {
            e.printStackTrace();
        }
    }

    public Object DeepClone() {
        return new Auto(this.brand, this.power, this.cost);
    }

    public Object clone() throws CloneNotSupportedException {
        return (Object) super.clone();
    }

    @Override
    public String toString() {
        return brand.toString();
    }
}

class Freight_ts extends Auto {
    int lifting_capacity;

    public Freight_ts() {
        super();
        lifting_capacity = 0;
    }

    public Freight_ts(String brand, int power, int cost, int lift_cap) {
        super(brand, power, cost);
        lifting_capacity = lift_cap;
    }

    @Override
    public void display() {
        super.display();
        System.out.println("Грузоподъемность: " + lifting_capacity + "т");
    }

    @Override
    public void read() {
        super.read();
        try {
            Scanner in = new Scanner(System.in);
            System.out.println("Грузоподъемность: ");
            lifting_capacity = in.nextInt();
        } catch (Exception error) {
            error.printStackTrace();
        }
    }
}

class Passenger_ts extends Auto {
    int num_of_seats;
    int max_speed;

    public Passenger_ts() {
        super();
        num_of_seats = 0;
    }

    public Passenger_ts(String brand, int power, int cost, int mspeed, int nseats) {
        super(brand, power, cost);
        max_speed = mspeed;
        num_of_seats = nseats;
    }

    @Override
    public void display() {
        super.display();
        System.out.println("Макс. скорость: " + max_speed + "\nЧисло посадочных мест: " + num_of_seats);
    }

    @Override
    public void read() {
        super.read();
        try {
            Scanner in = new Scanner(System.in);
            System.out.println("Макс. скорость:  ");
            max_speed = in.nextInt();
            System.out.println("Число посадочных мест:  ");
            num_of_seats = in.nextInt();
        } catch (Exception error) {
            error.printStackTrace();
        }
    }
}

class Person {
    public Person() {
        System.out.println("Появился человек");
    }
    public void toDrive(Veh veh) {
        veh.Drive();
    }
    public void toBuy(Veh veh) {
        veh.Buy();
    }
}

public class Main {
    public static void main(String[] args) {
    //    System.setProperty("console.encoding", "1251");
        Freight_ts f_ts = new Freight_ts("MAN", 800, 3000000, 20);
        Passenger_ts p_ts = new Passenger_ts("Ford", 200, 600000, 200, 5);
        f_ts.display();
        System.out.println("------------------------");
        p_ts.display();

        System.out.println("------------------------");

        Person guy = new Person();
        System.out.println("------------------------");
        guy.toBuy(f_ts);
        guy.toDrive(f_ts);
        System.out.println("------------------------");
        guy.toBuy(p_ts);
        guy.toDrive(p_ts);

        System.out.println("------------------------");

        Auto auto = new Auto("Nissan", 130, 200000);
        Auto auto1 = (Auto)auto.DeepClone();
        Auto auto2 = null;
        try {
            auto2 = (Auto)auto.clone();
        } catch (CloneNotSupportedException e) {
            e.printStackTrace();
        }
        System.out.println(auto1.toString());
        System.out.println(auto2);
    }
}
