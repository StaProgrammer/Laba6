using System.Collections.Generic;

class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> elements = new List<GraphicPrimitive>();

    public void Add(GraphicPrimitive element)
    {
        elements.Add(element);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a group:");
        foreach (var element in elements)
        {
            element.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        foreach (var element in elements)
        {
            element.Move(x, y);
        }
    }

    public void Scale(float factor)
    {
        foreach (var element in elements)
        {
            if (element is Circle)
            {
                ((Circle)element).Scale(factor);
            }
            else if (element is Rectangle)
            {
                ((Rectangle)element).Scale(factor);
            }
        }
    }
}
