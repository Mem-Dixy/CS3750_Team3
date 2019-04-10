namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		private static readonly System.Converter<database , view_list> converter;
		public static readonly view_list self;
		static view_list() {
			converter = (database item) => (view_list) item;
			self = new view_list();
		}
		public static view_list[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (view_list) item , () => new view_list() , subroutine , initialize);
		}
		public static view_list individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (view_list) item , () => new view_list() , subroutine , initialize);
		}
		public type.Int32 list;
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		public type.String poster;
		private view_list() : base("memdixyp_film" , "view_list") {
			this.list = new type.Int32("list");
			this.tconst = new type.String("tconst");
			this.primaryTitle = new type.String("primaryTitle");
			this.startYear = new type.Int16("startYear");
			this.poster = new type.String("poster");
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear),
				nameof(this.poster)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.tconst,
				this.primaryTitle,
				this.startYear,
				this.poster
			};
		}
		public static view_list[] show_movie_list(type.Int32 list) {
			System.String query = self.CALL(new type.abstraction[] {
				list
			});
			return collection(select , new System.Object[] { query });
		}
	}
}