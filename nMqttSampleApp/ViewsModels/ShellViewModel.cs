/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * http://code.google.com/p/nmqtt
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System;

namespace nMqtt.SampleApp.ViewModels
{
	public class ShellViewModel
	{
		public ShellViewModel()
		{
		}
		
		public string WindowTitle 
		{
			get
			{
				return "nMqtt Sample Test Application";
			}
		}
	}
}
