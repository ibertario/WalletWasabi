﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WalletWasabi.Hwi.Models
{
	public class HardwareWalletInfo
	{
		public HardwareWalletInfo(string fingerprint, string serialNumber, HardwareWalletType type, string path)
		{
			Fingerprint = fingerprint;
			SerialNumber = serialNumber;
			Type = type;
			Path = path;
		}

		public string Fingerprint { get; }
		public string SerialNumber { get; }
		public HardwareWalletType Type { get; }
		public string Path { get; }
	}
}
