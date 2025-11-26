using SpamDetectionExample;

SpamDetectionSystem spamDetectionSystem = new();

var email = new Email(
    Sender: "asdf@asdf.com",
    Subject: "Safe link to purchase, Nigerian Prince",
    Body: "123");

bool isSpam = spamDetectionSystem.CheckForSpam(email);

Console.WriteLine($"{email} is spam: {isSpam}");