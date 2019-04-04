﻿namespace Team3_Project.Databases.type {
	public class Int32 : abstraction {
		public System.Int32 value;
		public Int32() {
			this.value = 0;
		}
		public Int32(System.Int32 value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToInt32(Object);
		}
		public override System.Boolean parse(System.String text) {
			return System.Int32.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}