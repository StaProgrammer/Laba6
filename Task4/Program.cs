using System;
class Program
{
    static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();

        Circle circle = new Circle { X = 10, Y = 10, Radius = 5 };
        Rectangle rectangle = new Rectangle { X = 20, Y = 20, Width = 6, Height = 4 };
        Triangle triangle = new Triangle { X = 30, Y = 30 };

        Group group = new Group { X = 0, Y = 0 };
        group.Add(circle);
        group.Add(rectangle);

        editor.AddPrimitive(circle);
        editor.AddPrimitive(rectangle);
        editor.AddPrimitive(triangle);
        editor.AddPrimitive(group);

        editor.DrawPrimitives();

        group.Move(5, 5);
        group.Scale(2.0f);

        Console.WriteLine("\nAfter moving and scaling the group:");
        editor.DrawPrimitives();
    }
}
