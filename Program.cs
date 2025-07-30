using DesignPatterns.Behavioral;

// Strategy Design Pattern

PaymentContext context = new PaymentContext(new CreditCardPayment());
context.ExecutePayment(200);

context.SetStrategy(new BitcoinPayment());
context.ExecutePayment(400);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(800);
