using DiagramForge;
using SkiaSharp;

namespace TestProject1;
public class UnitTest1 {
	[Fact]
	public void Test1() {
		var text = new Text("foo");
		Assert.Equal("foo", text.ToString());
		text.SetSize();
		Assert.True(1 < text.width);
		Assert.True(1 < text.height);

		var row = new Row();
		row.contents.Add(new Text("foo"));
		row.contents.Add(new Text("bar"));
		row.SetSize();
		Assert.True(1 < row.width);
		Assert.True(1 < row.height);
		Assert.Equal(row.width, row.contents[0].width + row.contents[1].width);
		Assert.Equal(row.height, Math.Max(row.contents[0].height, row.contents[1].height));
	}

	[Fact]
	public void TestBitmap() {
		using var bitmap = new SKBitmap(1800, 900);
		using var canvas = new SKCanvas(bitmap);
		canvas.Clear(new SKColor(0xff, 0xff, 0xff));
		Assert.Equal(bitmap.GetPixel(0, 0), new SKColor(0xff, 0xff, 0xff));
	}
}
