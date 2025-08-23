using DesignPatterns.Behavioral;
using DesignPatterns.Creational;
using DesignPatterns.Structural;
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

Shape circle1 = new Circle(raster, 5);
Shape circle2 = new Circle(vector, 10);
Shape square1 = new Square(raster, 4);
Shape square2 = new Square(vector, 7);

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