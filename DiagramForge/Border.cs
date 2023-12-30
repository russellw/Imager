using SkiaSharp;

namespace DiagramForge;
public sealed class Border: Window {
	public SKColor background = new(0xff, 0xff, 0xff);
	public SKColor color = new(0, 0, 0);
	public Window content;
	public float radius = 2;

	public Border(Window content) {
		this.content = content;
	}

	public override void Draw(SKCanvas canvas) {
		using var paint = new SKPaint();
		paint.Color = color;
		canvas.DrawRect(x, y, width, height, paint);
		paint.Color = background;
		canvas.DrawRect(content.x, content.y, content.width, content.height, paint);
	}

	public override void SetPosition(float x, float y) {
		base.SetPosition(x, y);
		content.SetPosition(x + radius, y + radius);
	}

	public override void SetSize() {
		content.SetSize();
		width = content.width + radius * 2;
		height = content.height + radius * 2;
	}
}
