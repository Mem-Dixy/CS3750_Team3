﻿namespace Team3_Project.Databases.type {
	public class Byte : abstraction {
		public static Byte[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (Byte) item , () => new Byte() , subroutine , initialize);
		}
		public static Byte individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (Byte) item , () => new Byte() , subroutine , initialize);
		}
		public System.Byte value;
		public Byte() {
			this.value = 0;
		}
		public Byte(System.Byte value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			if (Object != System.DBNull.Value) {
				this.value = System.Convert.ToByte(Object);
			}
		}
		public override System.Boolean parse(System.String text) {
			return System.Byte.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}