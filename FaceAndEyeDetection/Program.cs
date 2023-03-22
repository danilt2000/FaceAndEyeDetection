using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;

internal class Program
{
	private static void Main(string[] args)
	{
		// načtení obrázku
		Image<Bgr, byte> img = new Image<Bgr, byte>("C:\\test\\FadeEyeDetection\\TestFace3.jpg");

		// převod obrázku na grayscale
		Image<Gray, byte> grayImg = img.Convert<Gray, byte>();

		// inicializace kaskády pro detekci obličejů
		CascadeClassifier faceCascade = new CascadeClassifier("C:\\test\\FadeEyeDetection\\haarcascade_frontalface_default.xml");

		// inicializace kaskády pro detekci očí
		CascadeClassifier eyeCascade = new CascadeClassifier("C:\\test\\FadeEyeDetection\\haarcascade_eye.xml");

		// detekce obličejeне з
		var faces = faceCascade.DetectMultiScale(
		grayImg,
		1.1, // koeficient zvětšení
		3, // minimální velikost oblasti
		Size.Empty,
		Size.Empty);

		// pro každý nalezený obličej
		foreach (var face in faces)
		{
			img.Draw(face, new Bgr(Color.Blue), 2);
		}
		var eyes = eyeCascade.DetectMultiScale(
			grayImg,
			1.1,
			3,
			Size.Empty,
			Size.Empty);
		foreach (var eye in eyes)
		{
			// vykreslení obdélníku kolem oka
			img.Draw(eye, new Bgr(Color.Red), 2);
		}

		img.Save("C:\\test\\FadeEyeDetection\\Vysledek3.jpg");
	}
}