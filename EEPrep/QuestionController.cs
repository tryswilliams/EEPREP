/**
 * Executes a query on the database to retrieve all the questions and store in an array list
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace EEPrep
{
    public class QuestionController
    {
        private IDbDataProvider provider;

        public QuestionController(IDbDataProvider provider)
        {
            this.provider = provider;
        }


        public IDbDataProvider GetDbProvider
        {
            get { return provider; }
        }


        public IEnumerable<Question> GetQuestions()
        {
            IDataReader dataReader = provider.ExecuteReader("SELECT * FROM rephie0000.ExamPrepQues;");
            IEnumerable<Question> results = new List<Question>();
           //TODO Figure out how to Clear the list
            // results.Question.Clear();
            while (dataReader.Read())
            {
                (results as List<Question>).Add(GetQuestion(dataReader));
            }
            return results;
        }

        private Question GetQuestion(IDataReader dataReader)
        {
            Question result = new Question();
            result.QuestionText = Convert.ToString(dataReader["Question"]);
            result.OptionA = Convert.ToString(dataReader["OptionA"]);
            result.OptionB = Convert.ToString(dataReader["OptionB"]);
            result.OptionC = Convert.ToString(dataReader["OptionC"]);
            result.OptionD = Convert.ToString(dataReader["OptionD"]);
            result.OptionE = Convert.ToString(dataReader["OptionE"]);
            result.Answer = Convert.ToChar(dataReader["Answer"]);
            result.Reason = Convert.ToString(dataReader["Reason"]);
            return result;
        }
    }
}