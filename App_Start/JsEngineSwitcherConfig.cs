using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.Jint;
using JavaScriptEngineSwitcher.Jurassic;
using JavaScriptEngineSwitcher.Msie;
using JavaScriptEngineSwitcher.NiL;
using JavaScriptEngineSwitcher.Node;
using JavaScriptEngineSwitcher.V8;
using JavaScriptEngineSwitcher.Vroom;

namespace ReactDemo
{
	public class JsEngineSwitcherConfig
	{
		public static void Configure(IJsEngineSwitcher engineSwitcher)
		{
			engineSwitcher.EngineFactories
				.AddChakraCore()
				.AddJint()
				.AddJurassic()
				.AddMsie(new MsieSettings
				{
					EngineMode = JsEngineMode.ChakraIeJsRt
				})
				.AddNiL()
				.AddNode()
				.AddV8()
				.AddVroom()
				;

			engineSwitcher.DefaultEngineName = ChakraCoreJsEngine.EngineName;
		}
	}
}