# The SOLID Principles of Object-Oriented Programming

SOLID is an acronym for five design principles that help developers write maintainable, scalable, and robust object-oriented code:

1. **S** — Single Responsibility Principle
2. **O** — Open/Closed Principle
3. **L** — Liskov Substitution Principle
4. **I** — Interface Segregation Principle
5. **D** — Dependency Inversion Principle

---

## 1. Single Responsibility Principle (SRP)

> A class should have only one responsibility, and therefore only one reason to change.

### Example

```java
// Book.java
public class Book {

    private String name;
    private String author;
    private String text;

    public Book(String name, String author, String text) {
        this.name = name;
        this.author = author;
        this.text = text;
    }

    public String getName() {
        return name;
    }

    public String getAuthor() {
        return author;
    }

    public String getText() {
        return text;
    }

    // Book-related responsibility
    public String replaceWordInText(String word, String replacementWord) {
        return text.replace(word, replacementWord);
    }

    public boolean isWordInText(String word) {
        return text.contains(word);
    }
}
```

```java
// BookPrinter.java
public class BookPrinter {

    // Printing responsibility
    public void printTextToConsole(Book book) {
        System.out.println("Book: " + book.getName());
        System.out.println("Author: " + book.getAuthor());
        System.out.println();
        System.out.println(book.getText());
    }
}
```

```java
// Main.java
public class Main {

    public static void main(String[] args) {

        Book book = new Book(
                "Java Basics",
                "John Doe",
                "Java is an object-oriented programming language."
        );

        // Book functionality
        System.out.println(book.isWordInText("Java"));

        String modifiedText =
                book.replaceWordInText("Java", "Python");

        System.out.println(modifiedText);

        System.out.println();

        // Printing functionality
        BookPrinter printer = new BookPrinter();
        printer.printTextToConsole(book);
    }
}
```

### Responsibilities

| Class | Responsibility |
|---|---|
| `Book` | Store and manipulate book data |
| `BookPrinter` | Print book information |
| `Main` | Use the classes and run the application |

### Why this follows SRP

- If the book structure changes (e.g., add ISBN), only `Book` changes.
- If the printing format changes (e.g., PDF, HTML, console styling), only `BookPrinter` changes.
- Each class has exactly one reason to change.

---

## 2. Open/Closed Principle (OCP)

> Classes should be open for extension but closed for modification.

This means existing, working code should not be edited to add new behavior. Instead, new functionality should be added by extending the class — reducing the risk of introducing bugs into code that already works.

### Example

Suppose we have a fully implemented `Guitar` class:

```java
public class Guitar {

    private String make;
    private String model;
    private int volume;

    // Constructors, getters & setters
}
```

We now want a version with a cool flame pattern. Instead of modifying `Guitar`, we **extend** it:

```java
public class SuperCoolGuitarWithFlames extends Guitar {

    private String flameColor;

    // Constructor, getters & setters
}
```

### Why this follows OCP

- `Guitar` remains untouched and stable.
- New behavior (`flameColor`) is added via a subclass.
- Existing code that depends on `Guitar` is unaffected.

---

## 3. Liskov Substitution Principle (LSP)

> Derived classes must be substitutable for their base classes without altering the correctness of the program. A subclass should extend behavior, not break the expectations established by the parent class.

### LSP Violation Example

```java
class Bird {
    public void fly() {
        System.out.println("Flying...");
    }
}

class Penguin extends Bird {
    @Override
    public void fly() {
        throw new UnsupportedOperationException("Penguins can't fly");
    }
}
```

Usage:

```java
Bird bird = new Penguin();
bird.fly();
```

Runtime result:

```text
Exception!
```

### What's Wrong

- The parent class `Bird` promises a working `fly()` method.
- `Penguin` cannot honor that promise.
- `Bird bird = new Penguin();` therefore breaks the expected behavior — this **violates LSP**.

### Why It Happens

The inheritance hierarchy was modeled incorrectly — not all birds can fly.

### Correct Design

```java
// General bird
class Bird {
    public void eat() {
        System.out.println("Eating...");
    }
}

// Flying bird
class FlyingBird extends Bird {
    public void fly() {
        System.out.println("Flying...");
    }
}

// Sparrow can fly
class Sparrow extends FlyingBird {
}

// Penguin cannot fly
class Penguin extends Bird {
}
```

Now both of these work correctly:

```java
Bird bird1 = new Penguin();
Bird bird2 = new Sparrow();
```

And so does this:

```java
FlyingBird bird = new Sparrow();
bird.fly();
```

---

## 4. Interface Segregation Principle (ISP)

> A class should not be forced to implement interfaces or methods that it does not use. Instead of creating large, general-purpose interfaces, create smaller, more specific ones.

### Problem

When a large interface contains methods irrelevant to all implementing classes, some classes are forced to provide unnecessary implementations — leading to unused methods, empty bodies, or thrown exceptions.

### Bad Example

```java
interface Worker {
    void work();
    void eat();
}

class HumanWorker implements Worker {
    public void work() {
        System.out.println("Working");
    }

    public void eat() {
        System.out.println("Eating");
    }
}

class RobotWorker implements Worker {
    public void work() {
        System.out.println("Working");
    }

    public void eat() {
        // Robots do not eat
    }
}
```

Here, `RobotWorker` is forced to implement `eat()`, even though robots do not eat — this **violates ISP**.

### Solution

Split large interfaces into smaller, role-specific interfaces.

```java
interface Workable {
    void work();
}

interface Eatable {
    void eat();
}

class HumanWorker implements Workable, Eatable {
    public void work() {
        System.out.println("Working");
    }

    public void eat() {
        System.out.println("Eating");
    }
}

class RobotWorker implements Workable {
    public void work() {
        System.out.println("Working");
    }
}
```

Now each class implements only the interfaces relevant to it.

### Benefits

- Reduces unnecessary dependencies.
- Improves maintainability.
- Makes code easier to understand.
- Prevents empty or unsupported method implementations.
- Encourages modular and flexible design.

### Key Idea

> Clients should not be forced to depend on methods they do not use. A class should implement only the interfaces that are meaningful for its behavior.

---

## 5. Dependency Inversion Principle (DIP)

> High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details; details should depend on abstractions.

In simple terms: classes should depend on **interfaces**, not concrete implementations.

### Problem

When a high-level class directly depends on a specific implementation, the code becomes tightly coupled, and any change to the implementation can ripple into the high-level class.

### Bad Example

```java
class EmailService {

    public void sendEmail(String message) {
        System.out.println("Sending Email: " + message);
    }
}

class Notification {

    private EmailService emailService = new EmailService();

    public void send(String message) {
        emailService.sendEmail(message);
    }
}
```

### Issues

- `Notification` is tightly coupled to `EmailService`.
- Switching from Email to SMS requires modifying `Notification`.
- Difficult to test because dependencies are hardcoded.
- Violates the Dependency Inversion Principle.

### Solution

Introduce an abstraction (interface) so both high-level and low-level modules depend on it.

**Step 1 — Create an interface:**

```java
interface MessageService {
    void sendMessage(String message);
}
```

**Step 2 — Implement the interface:**

```java
class EmailService implements MessageService {

    @Override
    public void sendMessage(String message) {
        System.out.println("Sending Email: " + message);
    }
}

class SMSService implements MessageService {

    @Override
    public void sendMessage(String message) {
        System.out.println("Sending SMS: " + message);
    }
}
```

**Step 3 — Depend on the abstraction:**

```java
class Notification {

    private MessageService messageService;

    public Notification(MessageService messageService) {
        this.messageService = messageService;
    }

    public void send(String message) {
        messageService.sendMessage(message);
    }
}
```

### Usage

```java
public class Main {

    public static void main(String[] args) {

        MessageService service = new EmailService();

        Notification notification = new Notification(service);

        notification.send("Hello World");
    }
}
```

Output:

```text
Sending Email: Hello World
```

To switch to SMS, only this line changes — `Notification` itself stays untouched:

```java
MessageService service = new SMSService();
```

### Benefits

1. Reduces coupling between classes.
2. Makes code easier to maintain and extend.
3. Simplifies unit testing using mock implementations.
4. Supports the Open/Closed Principle by allowing new implementations without modifying existing code.
5. Improves flexibility and scalability.

### Real-World Analogy

A laptop does not depend on a specific keyboard model — it depends on a USB interface, and any USB-compatible keyboard can be connected without changing the laptop's design. Similarly, a class should depend on an interface rather than a specific implementation.

### Key Idea

> Depend on abstractions, not on concrete implementations.

**Instead of:**

```text
Notification
      ↓
EmailService
```

**Use:**

```text
Notification
      ↓
MessageService
      ↑
EmailService / SMSService
```

This keeps the system flexible, loosely coupled, and easy to maintain.
