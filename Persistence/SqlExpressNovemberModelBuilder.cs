﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using SqlExpressNovember.EntityClasses;

namespace SqlExpressNovember
{
	/// <summary>Model builder class for code first development.</summary>
	public partial class SqlExpressNovemberModelBuilder
	{
		/// <summary>Builds the model defined in this class with the modelbuilder specified. Called from the generated DbContext</summary>
		/// <param name="modelBuilder">The model builder to build the model with.</param>
		public virtual void BuildModel(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("dbo");
			MapApiDataSource(modelBuilder.Entity<ApiDataSource>());
			MapMovieCreditResult(modelBuilder.Entity<MovieCreditResult>());
			MapMovieNotFound(modelBuilder.Entity<MovieNotFound>());
			MapMovieResult(modelBuilder.Entity<MovieResult>());
		}

		/// <summary>Defines the mapping information for the entity 'ApiDataSource'</summary>
		/// <param name="config">The configuration to modify.</param>
		protected virtual void MapApiDataSource(EntityTypeConfiguration<ApiDataSource> config)
		{
			config.ToTable("ApiDataSource");
			config.HasKey(t => t.Id);
			config.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			config.Property(t => t.SourceName).HasMaxLength(50).IsRequired();
			config.Property(t => t.SourceBaseUrl).HasMaxLength(200);
		}

		/// <summary>Defines the mapping information for the entity 'MovieCreditResult'</summary>
		/// <param name="config">The configuration to modify.</param>
		protected virtual void MapMovieCreditResult(EntityTypeConfiguration<MovieCreditResult> config)
		{
			config.ToTable("MovieCreditResult");
			config.HasKey(t => new { t.ItemId, t.RowId });
			config.Property(t => t.ItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			config.Property(t => t.RowId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			config.Property(t => t.ItemSearchTitle).HasMaxLength(100);
			config.Property(t => t.ApiUrl).HasMaxLength(200);
			config.Property(t => t.ResultNum);
			config.Property(t => t.Name).HasMaxLength(100);
			config.Property(t => t.Order);
			config.Property(t => t.CastId).HasColumnName("Cast_Id");
			config.Property(t => t.Character).HasMaxLength(100);
			config.Property(t => t.CreditId).HasColumnName("Credit_Id").HasMaxLength(50);
			config.Property(t => t.TmdId);
			config.Property(t => t.ProfilePath).HasColumnName("Profile_Path").HasMaxLength(200);
			config.Property(t => t.AddedOn);
			config.Property(t => t.ChangedOn);
		}

		/// <summary>Defines the mapping information for the entity 'MovieNotFound'</summary>
		/// <param name="config">The configuration to modify.</param>
		protected virtual void MapMovieNotFound(EntityTypeConfiguration<MovieNotFound> config)
		{
			config.ToTable("MovieNotFound");
			config.HasKey(t => new { t.ItemId, t.ItemSource });
			config.Property(t => t.ItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			config.Property(t => t.ItemSource).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			config.Property(t => t.RowId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
			config.Property(t => t.ItemSearchTitle).HasMaxLength(100);
			config.Property(t => t.ItemSearchYear);
			config.Property(t => t.AddedOn);
			config.Property(t => t.ChangedOn);
		}

		/// <summary>Defines the mapping information for the entity 'MovieResult'</summary>
		/// <param name="config">The configuration to modify.</param>
		protected virtual void MapMovieResult(EntityTypeConfiguration<MovieResult> config)
		{
			config.ToTable("MovieResult");
			config.HasKey(t => new { t.ItemId, t.ItemSource, t.RowId });
			config.Property(t => t.ItemId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			config.Property(t => t.ItemSearchTitle).HasMaxLength(100).IsRequired();
			config.Property(t => t.ItemSource).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
			config.Property(t => t.RowId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			config.Property(t => t.ItemSearchYear);
			config.Property(t => t.ApiUrl).HasMaxLength(200);
			config.Property(t => t.ResultTitle).HasMaxLength(100);
			config.Property(t => t.ResultYear);
			config.Property(t => t.IsMovie);
			config.Property(t => t.ResultCt);
			config.Property(t => t.Page);
			config.Property(t => t.TotalPages).HasColumnName("Total_Pages");
			config.Property(t => t.TotalResults).HasColumnName("Total_Results");
			config.Property(t => t.ResultNum);
			config.Property(t => t.GenreIds).HasColumnName("Genre_Ids").HasMaxLength(100);
			config.Property(t => t.OriginalLanguage).HasColumnName("Original_Language").HasMaxLength(50);
			config.Property(t => t.OriginalTitle).HasColumnName("Original_Title").HasMaxLength(100);
			config.Property(t => t.Overview);
			config.Property(t => t.ReleaseDate).HasColumnName("Release_Date").HasMaxLength(50);
			config.Property(t => t.PosterPath).HasColumnName("Poster_Path").HasMaxLength(250);
			config.Property(t => t.Popularity);
			config.Property(t => t.Video);
			config.Property(t => t.VoteAverage).HasColumnName("Vote_Average");
			config.Property(t => t.VoteCount).HasColumnName("Vote_Count");
			config.Property(t => t.Rated).HasMaxLength(50);
			config.Property(t => t.Released).HasMaxLength(50);
			config.Property(t => t.Runtime).HasMaxLength(50);
			config.Property(t => t.Genre).HasMaxLength(50);
			config.Property(t => t.Director).HasMaxLength(100);
			config.Property(t => t.Writer).HasMaxLength(100);
			config.Property(t => t.Actors);
			config.Property(t => t.Plot);
			config.Property(t => t.Language).HasMaxLength(50);
			config.Property(t => t.Country).HasMaxLength(50);
			config.Property(t => t.Awards).HasMaxLength(100);
			config.Property(t => t.Poster).HasMaxLength(200);
			config.Property(t => t.MetaScore).HasMaxLength(50);
			config.Property(t => t.ImdbRating).HasMaxLength(50);
			config.Property(t => t.ImdbVotes).HasMaxLength(50);
			config.Property(t => t.ImdbId).HasMaxLength(50);
			config.Property(t => t.Type).HasMaxLength(100);
			config.Property(t => t.Tmeter).HasColumnName("TMeter").HasMaxLength(100);
			config.Property(t => t.Timage).HasColumnName("TImage").HasMaxLength(200);
			config.Property(t => t.Trating).HasColumnName("TRating").HasMaxLength(50);
			config.Property(t => t.Treviews).HasColumnName("TReviews");
			config.Property(t => t.Tfresh).HasColumnName("TFresh").HasMaxLength(50);
			config.Property(t => t.Trotten).HasColumnName("TRotten").HasMaxLength(50);
			config.Property(t => t.Tconsensus).HasColumnName("TConsensus").HasMaxLength(50);
			config.Property(t => t.TuserMeter).HasColumnName("TUserMeter").HasMaxLength(50);
			config.Property(t => t.TuserRating).HasColumnName("TUserRating").HasMaxLength(50);
			config.Property(t => t.TuserReviews).HasColumnName("TUserReviews");
			config.Property(t => t.Dvd).HasColumnName("DVD").HasMaxLength(100);
			config.Property(t => t.BoxOffice).HasMaxLength(50);
			config.Property(t => t.Production).HasMaxLength(50);
			config.Property(t => t.Website).HasMaxLength(200);
			config.Property(t => t.Response).HasMaxLength(10);
			config.Property(t => t.AddedOn);
			config.Property(t => t.ChangedOn);
		}
	}
}
