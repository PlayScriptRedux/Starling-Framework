// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace OpenGLLayer {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
	}
	
	// Should subclass MonoMac.AppKit.NSView
	[MonoMac.Foundation.Register("MyView")]
	public partial class MyView {
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("toggle:")]
		partial void toggle (MonoMac.AppKit.NSButton sender);
}
}