public class Triangle : Shape
{
    public string Name { get; } = "Triangle";
    public int MaxHeight { get; } = 40;
    public int MinHeight { get; } = 2;

    public void Display(int heightOfShape, char charForShape)
    {
        StringWriter shapeText = new StringWriter();
        int lineWidth = heightOfShape * 2 - 1;
        for (int line = 0; line < heightOfShape; line++)
        {
            int charsOnThisLine = line + 1;
            string thisLine = "";
            for (int i = 0; i < charsOnThisLine; i++)
            {
                thisLine += (i == heightOfShape) ? charForShape : charForShape + " ";
            }
            for (int i = 0; i < lineWidth - thisLine.Length; i++)
            {
                thisLine = " " + thisLine;
            }
            shapeText.WriteLine(thisLine);
        }

        Console.Write(shapeText);
    }

}
