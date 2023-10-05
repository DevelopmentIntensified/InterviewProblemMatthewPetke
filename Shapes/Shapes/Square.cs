public class Square : Shape
{
    public string Name { get; } = "Square";
    public int MaxHeight { get; } = 50;
    public int MinHeight { get; } = 2;

    public void Display(int heightOfShape, char charForShape)
    {
        StringWriter shapeText = new StringWriter();
        for (int line = 0; line < heightOfShape; line++)
        {
            string thisLine = "";
            for (int i = 0; i < heightOfShape; i++)
            {
                thisLine += (i == heightOfShape) ? charForShape : charForShape + " ";
            }
            shapeText.WriteLine(thisLine);
        }
        Console.Write(shapeText);
    }

}
