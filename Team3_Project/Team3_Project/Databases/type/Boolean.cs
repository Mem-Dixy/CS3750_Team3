﻿namespace Team3_Project.Databases.type {
	public class Boolean : abstraction {
		public static Boolean[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (Boolean) item , () => new Boolean() , subroutine , initialize);
		}
		public static Boolean individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (Boolean) item , () => new Boolean() , subroutine , initialize);
		}
		public System.Boolean value;
		public Boolean() {
			this.value = false;
		}
		public Boolean(System.Boolean value) {
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
				this.value = System.Convert.ToBoolean(Object);
			}
		}
		public override System.Boolean parse(System.String text) {
			return System.Boolean.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}