using System.Runtime.InteropServices;

namespace LibGlide; 

public static class Program {
	[DllImport("glide")]
	public static extern void grGlideInit();
	[DllImport("glide")]
	public static extern void grSstSelect(int card);
	[DllImport("glide")]
	public static extern void grSstWinOpen(int hwnd, int res, int @ref, int format, int origin, int buffers, int aux_buffers);
	[DllImport("glide")]
	public static extern void grBufferClear(uint color, byte alpha, ushort depth);
	[DllImport("glide")]
	public static extern void grBufferSwap(int interval);

	public static void Main() {
		grGlideInit();
		grSstSelect(0);
		grSstWinOpen(0, 7, 0, 1, 0, 2, 1);
		grBufferClear(0x0000ff, 0x00, 0xffff);
		grBufferSwap(1);
	}
}