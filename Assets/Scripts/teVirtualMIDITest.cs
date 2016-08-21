using UnityEngine;
using Sanford.Multimedia.Midi;
using System;
using System.Threading;

namespace TobiasErichsen.teVirtualMIDI.test {


	public class KeyToSoundIntegrator{

		

		public static void ProduceSound(int note)
		{
			using (OutputDevice outDevice = new OutputDevice(3))
			{
				ChannelMessageBuilder builder = new ChannelMessageBuilder();

				builder.Command = ChannelCommand.NoteOn;
				builder.MidiChannel = 0;
				builder.Data1 = note;
				builder.Data2 = 127;
				builder.Build();
                		Debug.Log(note);

				outDevice.Send(builder.Result);
			}
		}
}
