using DesignPatterns.Behavioral;
using DesignPatterns.Structural;

// Strategy Design Pattern

PaymentContext context = new PaymentContext(new CreditCardPayment());
context.ExecutePayment(200);

context.SetStrategy(new BitcoinPayment());
context.ExecutePayment(400);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(800);


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


// Decorator Design Pattern

ICoffee coffee = new BasicCoffee(); 
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");

coffee = new MilkDecorator(coffee); 
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");

coffee = new SugarDecorator(coffee);
Console.WriteLine($"{coffee.GetDescription()} = ${coffee.GetCost()}");
