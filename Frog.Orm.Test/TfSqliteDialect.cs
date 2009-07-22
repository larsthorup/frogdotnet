﻿using Frog.Orm.Dialects;
using Frog.Orm.Syntax;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Frog.Orm.Test
{
    [TestFixture]
    public class TfSqliteDialect
    {
        [Test]
        public void SelectIdentity()
        {
            var dialect = new SqliteDialect();
            Assert.That(dialect.SelectIdentity(), Is.EqualTo("SELECT last_insert_rowid()"));
        }

        [Test]
        public void SelectColumnsUnquoted()
        {
            var dialect = new SqliteDialect();
            Assert.That(dialect.Select("Samples", Field.List("Id")), Is.EqualTo("SELECT Id FROM [Samples]"));
        }
    }
}