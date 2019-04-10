namespace Team3_Project.Databases.memdixyp_imdb {
	public class name_basics : database {
		private static readonly System.Converter<database , name_basics> converter;
		public static readonly name_basics self;
		static name_basics() {
			converter = (database item) => (name_basics) item;
			self = new name_basics();
		}
		public static name_basics[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (name_basics) item , () => new name_basics() , subroutine , initialize);
		}
		public static name_basics individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (name_basics) item , () => new name_basics() , subroutine , initialize);
		}
		public type.String nconst;
		public type.String primaryName;
		public type.Int16 birthYear;
		public type.Int16 deathYear;
		public type.String primaryProfession;
		public type.String knownForTitles;
		private name_basics() : base("memdixyp_imdb" , "name_basics") {
			this.nconst = new type.String("nconst");
			this.primaryName = new type.String("primaryName");
			this.birthYear = new type.Int16("birthYear");
			this.deathYear = new type.Int16("deathYear");
			this.primaryProfession = new type.String("primaryProfession");
			this.knownForTitles = new type.String("knownForTitles");
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.nconst),
				nameof(this.primaryName),
				nameof(this.birthYear),
				nameof(this.deathYear),
				nameof(this.primaryProfession),
				nameof(this.knownForTitles)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.nconst,
				this.primaryName,
				this.birthYear,
				this.deathYear,
				this.primaryProfession,
				this.knownForTitles
			};
		}
	}
}