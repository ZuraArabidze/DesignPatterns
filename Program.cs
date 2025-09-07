using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Structural;
using DesignPatterns.Structural.Composite;
using System.Reflection.Metadata;

// Strategy Design Pattern

PaymentContext context = new PaymentContext(new CreditCardPayment());
context.ExecutePayment(200);

context.SetStrategy(new BitcoinPayment());
context.ExecutePayment(400);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(800);

Console.WriteLine("-----------------------------");

// Observer Design Pattern

NewsAgency agency = new NewsAgency();

NewsSubscriber zura = new NewsSubscriber("Zura");
NewsSubscriber rezi = new NewsSubscriber("Rezi");

agency.Subscribe(zura);
agency.Subscribe(rezi);

agency.PublishNews("Observer Pattern Implemented!");

Console.WriteLine("\n-- Rezi Unsubscribes --\n");
agency.Unsubscribe(rezi);

agency.PublishNews("Learning Design Patterns!");

Console.WriteLine("-----------------------------");

// Decorator Design Pattern

ICoffee coffee = new BasicCoffee(); 
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");

coffee = new MilkDecorator(coffee); 
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");

coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");

Console.WriteLine("-----------------------------");

// Factory Design Pattern

DocumentCreator creator;

creator = new WordDocumentCreator();
creator.PrintDocument();

creator = new PdfDocumentCreator();
creator.PrintDocument();

Console.WriteLine("-----------------------------");

// Abstract Design Pattern 

IGUIFactory factory = new WindowsFactory();
IGUIFactory factory1 = new MacFactory();

Application app = new Application(factory);
app.RenderUI();

Application app1 = new Application(factory1);
app1.RenderUI();

Console.WriteLine("-----------------------------");

// Singleton Design Pattern

var singleton1 = Singleton.GetInstance();
var  singleton2 = Singleton.GetInstance();

singleton1.DoSomething();
singleton2.DoSomething();

Console.WriteLine($"Same instance? {singleton1 == singleton2}");

Console.WriteLine("-----------------------------");

// Command Design Pattern

var light = new Light();

var turnOn = new TurnOnCommand(light);
var turnOff = new TurnOffCommand(light);

var remote = new RemoteControl();

remote.SetCommand(turnOn);
remote.PressButton();    
remote.PressUndo();   

remote.SetCommand(turnOff);
remote.PressButton();
remote.PressUndo();


Console.WriteLine("-----------------------------");

// Adapter Design Pattern

Adaptee adaptee = new Adaptee();
ITarget target = new Adapter(adaptee);

Console.WriteLine("Adaptee interface is incompatible with the client.");
Console.WriteLine("But with adapter client can call it's method.");

Console.WriteLine(target.GetRequest());

Console.WriteLine("-----------------------------");

// Facade Design Pattern

var dvd = new DvdPlayer();
var projector = new Projector();
var sound = new SoundSystem();
var lights = new Lights();

var theater = new HomeTheaterFacade(dvd, projector, sound, lights);
theater.WatchMovie("Inception");
Console.WriteLine();
theater.EndMovie();

Console.WriteLine("-----------------------------");

// Proxy Design Pattern 

IImage image1 = new ProxyImage("photo1.jpg");

Console.WriteLine("Image not loaded yet...");
Console.WriteLine("Now displaying image...");
image1.Display();

Console.WriteLine("\nDisplaying again...");
image1.Display();

Console.WriteLine("-----------------------------");

// Bridge Design Pattern

var raster = new RasterRenderer();
var vector = new VectorRenderer();

DesignPatterns.Structural.Shape circle1 = new DesignPatterns.Structural.Circle(raster, 5);
DesignPatterns.Structural.Shape circle2 = new DesignPatterns.Structural.Circle(vector, 10);
DesignPatterns.Structural.Shape square1 = new DesignPatterns.Structural.Square(raster, 4);
DesignPatterns.Structural.Shape square2 = new DesignPatterns.Structural.Square(vector, 7);

circle1.Draw();   
circle2.Draw();   
square1.Draw();   
square2.Draw();


Console.WriteLine("-----------------------------");

// Template Method Design Pattern
DataParser csv = new CsvParser();
csv.ProcessData();

Console.WriteLine();

DataParser json = new JsonParser();
json.ProcessData();


Console.WriteLine("-----------------------------");

//Composite Design Pattern
var circle = new DesignPatterns.Structural.Composite.Circle();
var square = new DesignPatterns.Structural.Composite.Square();

var group = new CompoundGraphic();
group.Add(circle);
group.Add(square);

circle.Draw();
square.Draw();
group.Draw();

Console.WriteLine("-----------------------------");

//Iterator Design Pattern
SongCollection songs = new SongCollection();
songs.AddSong(new Song("Shape of You", "Ed Sheeran"));
songs.AddSong(new Song("Believer", "Imagine Dragons"));

IIterator<Song> songIterator = songs.CreateIterator();
Console.WriteLine("SongCollection:");
while (songIterator.HasNext())
{
    Song song = songIterator.Next();
    Console.WriteLine($"{song.Title} - {song.Artist}");
}

Console.WriteLine();


PlaylistCollection playlist = new PlaylistCollection(3);
playlist.AddSong(new Song("Thunderstruck", "AC/DC"));
playlist.AddSong(new Song("Smells Like Teen Spirit", "Nirvana"));

IIterator<Song> playlistIterator = playlist.CreateIterator();
Console.WriteLine("PlaylistCollection:");
while (playlistIterator.HasNext())
{
    Song song = playlistIterator.Next();
    Console.WriteLine($"{song.Title} - {song.Artist}");
}

Console.WriteLine("-----------------------------");

// State Design Pattern
var player = new MusicPlayer();

player.Play();   
player.Pause();  
player.Play();   
player.Stop();

Console.WriteLine("-----------------------------");

// Null Object Design Pattern
var repo = new CustomerRepository();

ICustomer customer1 = repo.GetCustomer("Zura");
ICustomer customer2 = repo.GetCustomer("Zura3");

Console.WriteLine(customer1.GetName());
customer1.PlaceOrder("Coffee");

Console.WriteLine(customer2.GetName()); 
customer2.PlaceOrder("Tee");

Console.WriteLine("-----------------------------");

// Builder Design Pattern
var director = new CarDirector();

var sportsBuilder = new SportsCarBuilder();
director.Construct(sportsBuilder);
Car sportsCar = sportsBuilder.GetResult();
Console.WriteLine(sportsCar);

var suvBuilder = new SUVCarBuilder();
director.Construct(suvBuilder);
Car suvCar = suvBuilder.GetResult();
Console.WriteLine(suvCar);

Console.WriteLine("-----------------------------");

// Prototype Design Pattern
var originalShape = new DesignPatterns.Creational.Shape { Color = "Red", X = 10, Y = 20 };
var originalCircle = new DesignPatterns.Creational.Circle { Color = "Blue", Radius = 5.5 };

var clonedShape = originalShape.Clone();
var clonedCircle = originalCircle.Clone();

clonedShape.Color = "Green";
clonedCircle.Radius = 10;

Console.WriteLine("Originals:");
Console.WriteLine(originalShape);
Console.WriteLine(originalCircle);

Console.WriteLine("\nClones:");
Console.WriteLine(clonedShape);
Console.WriteLine(clonedCircle);

Console.WriteLine("-----------------------------");

// Mediator Design Pattern
Component1 component1 = new Component1();
Component2 component2 = new Component2();
new ConcreteMediator(component1, component2);

Console.WriteLine("Client triggers operation A.");
component1.DoA();

Console.WriteLine();

Console.WriteLine("Client triggers operation D.");
component2.DoD();

Console.WriteLine("-----------------------------");

// Memento Design Pattern
Originator originator = new Originator("Super-duper-super-puper-super.");
Caretaker caretaker = new Caretaker(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine("\nClient: Now, let's rollback!\n");
caretaker.Undo();

Console.WriteLine("\n\nClient: Once more!\n");
caretaker.Undo();

Console.WriteLine("-----------------------------");