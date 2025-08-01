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