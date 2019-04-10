namespace Team3_Project.Databases.type {
	public class DateTime : abstraction {
		public static DateTime[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (DateTime) item , () => new DateTime("") , subroutine , initialize);
		}
		public static DateTime individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (DateTime) item , () => new DateTime("") , subroutine , initialize);
		}
		public System.String name;
		public System.DateTime value;
		public DateTime(System.String name) {
			this.name = name;
			this.value = System.DateTime.UtcNow;
		}
		public DateTime(System.String name , System.DateTime value) {
			this.name = name;
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
				this.value = System.Convert.ToDateTime(Object);
			}
		}
		public override System.Boolean parse(System.String text) {
			return System.DateTime.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}