using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Godot;
using Godot.Collections;

namespace thefirey33thegame.scripts;

public partial class InputSystem : Node
{

	private const string ConfigurationFilePath = "user://InputSystem.xml";

	private static string ConfigurationGlobalPath => ProjectSettings.GlobalizePath(ConfigurationFilePath);
	private static void CreateInputFile()
	{
		var configDocument = new XDocument(new XElement("input_system_config"));
		var rootNode = configDocument.Root ?? throw new NullReferenceException("XML Root not found!");
		
		var inputMappings = InputMap.GetActions();
		foreach (var inputMapping in inputMappings)
		{
			var innerConfiguration = new Dictionary<string, int>();
			var actionEvents = InputMap.ActionGetEvents(inputMapping);
			
			for (var i = 0; i < actionEvents.Count; i++)
			{
				var actionEvent = actionEvents[i];
				switch (actionEvent)
				{
					case InputEventKey actionEventKey:
						break;
					case InputEventJoypadButton actionEventJoypadButton:
						break;
				}
			}
		}
	}
	
	
	
	public override void _Ready()
	{
		CreateInputFile();
	}

}