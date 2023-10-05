public class Diamond : Shape 
{
    public string Name { get; } = "Diamond";
    public int MaxHeight { get; } = 60;
    public int MinHeight { get; } = 5;

    public void Display(int heightOfShape, char charForShape)
    {
        StringWriter shapeText = new StringWriter();
        int lineWidth = heightOfShape * 2 - 1;
        bool isEven = (heightOfShape % 2 == 0);
        int needToAddOne = (isEven) ? 0 : 1;
        int halfOfShapeHeight = heightOfShape / 2;

        for (int line = 0; line < heightOfShape; line++)
        {
            int charsOnThisLine = (line < halfOfShapeHeight) ? line + 1 : halfOfShapeHeight + needToAddOne - (line - halfOfShapeHeight);
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
