﻿//Creation Time: 2010-08-20
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace Sandwych.Reporting
{
	/// <summary>
	///  Memory stream of write-only
	/// </summary>
	internal sealed class OutputMemoryStream : MemoryStream
	{
		private readonly string name;
		private readonly IDictionary<string, byte[]> entries;

		public OutputMemoryStream (string name, IDictionary<string, byte[]> entries)
		{
			Debug.Assert (entries != null);
			Debug.Assert (!string.IsNullOrEmpty (name));

			this.name = name;
			this.entries = entries;
		}

		protected override void Dispose (bool disposing)
		{
			this.entries [this.name] = this.ToArray ();

			base.Dispose (disposing);
		}

		public override bool CanRead {
			get {
				return false;
			}
		}

		public override bool CanSeek {
			get {
				return false;
			}
		}

		public override bool CanWrite {
			get {
				return true;
			}
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException ();
		}

		public override int ReadByte ()
		{
			throw new NotSupportedException ();
		}

		public override long Position {
			get {
				return base.Position;
			}
			set {
				throw new NotSupportedException ();
			}
		}

		public override long Seek (long offset, SeekOrigin loc)
		{
			throw new NotSupportedException ();
		}
	}
}
