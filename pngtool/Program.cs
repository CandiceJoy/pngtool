using ImageMagick;

class Program
{
	static void Main( string[] args )
	{
		string file      = args[0];
		int   colorType = int.Parse( args[1] );

		if( !File.Exists( file ) )
		{
			Console.WriteLine( "Cannot find file " + file );
			return;
		}

		Console.WriteLine("Desired color type: " + colorType + "("+(ImageMagick.ColorType)colorType+")");

		MagickImage image = new MagickImage( file );

		Console.WriteLine("Size: "           + image.Width          + "x" + image.Height);
		Console.WriteLine("Old color type: " + (int)image.ColorType + "(" +image.ColorType +")");

		image.ColorType = (ImageMagick.ColorType)colorType;
		image.Write( file );
		image = new MagickImage( file );
		Console.WriteLine("New color type: " + (int)image.ColorType + "("+image.ColorType+")");
	}
}
