/* Title:           Trailer Current Load Class
 * Date:            9-7-18
 * Author:          Terry Holmes
 * 
 * Description:     This is the class to for Trailer Current Load */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace TrailerCurrentLoadDLL
{
    public class TrailerCurrentLoadClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        TrailerCurrentLoadDataSet aTrailerCurrentLoadDataSet;
        TrailerCurrentLoadDataSetTableAdapters.trailercurrentloadTableAdapter aTrailerCurrentLoadTableAdapter;

        InsertTrailerCurrentLoadEntryTableAdapters.QueriesTableAdapter aInsertTrailerCurrentLoadTableAdapter;

        UpdateTrailerCurrentLoadEntryTableAdapters.QueriesTableAdapter aUpdateTrailerCurrentLoadTableAdapter;

        UpdateTrailerCurrentLoadFootageEntryTableAdapters.QueriesTableAdapter aUpdateTrailerCurrentLoadFootageTableAdapter;

        FindSortedTrailerCurrentLoadDataSet aFindSortedTrailerCurrentLoadDataSet;
        FindSortedTrailerCurrentLoadDataSetTableAdapters.FindSortedTrailerCurrentLoadTableAdapter aFindSortedTrailerCurrentLoadTableAdapter;

        FindTrailerCurrentLoadByCableTypeDataSet aFindTrailerCurrentLoadByCableTypeDataSet;
        FindTrailerCurrentLoadByCableTypeDataSetTableAdapters.FindTrailerCurrentLoadByCableTypeTableAdapter aFindTrailerCurrentLoadByCableTypeTableAdapter;

        FindTrailerCurrentLoadByTrailerNumberDataSet aFindTrailerCurrentLoadByTrailerNumberDataSet;
        FindTrailerCurrentLoadByTrailerNumberDataSetTableAdapters.FindTrailerCurrentLoadByTrailerNumberTableAdapter aFindTrailerCurrentLoadByTrailerNumberTableAdapter;

        public FindTrailerCurrentLoadByTrailerNumberDataSet FindTrailerCurrentLoadByTrailerNumber(string strTrailerNumber)
        {
            try
            {
                aFindTrailerCurrentLoadByTrailerNumberDataSet = new FindTrailerCurrentLoadByTrailerNumberDataSet();
                aFindTrailerCurrentLoadByTrailerNumberTableAdapter = new FindTrailerCurrentLoadByTrailerNumberDataSetTableAdapters.FindTrailerCurrentLoadByTrailerNumberTableAdapter();
                aFindTrailerCurrentLoadByTrailerNumberTableAdapter.Fill(aFindTrailerCurrentLoadByTrailerNumberDataSet.FindTrailerCurrentLoadByTrailerNumber, strTrailerNumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Find Trailer Current Load By Trailer Number " + Ex.Message);
            }

            return aFindTrailerCurrentLoadByTrailerNumberDataSet;
        }
        public FindTrailerCurrentLoadByCableTypeDataSet FindTrailerCurrentLoadByCableType(string strCableType)
        {
            try
            {
                aFindTrailerCurrentLoadByCableTypeDataSet = new FindTrailerCurrentLoadByCableTypeDataSet();
                aFindTrailerCurrentLoadByCableTypeTableAdapter = new FindTrailerCurrentLoadByCableTypeDataSetTableAdapters.FindTrailerCurrentLoadByCableTypeTableAdapter();
                aFindTrailerCurrentLoadByCableTypeTableAdapter.Fill(aFindTrailerCurrentLoadByCableTypeDataSet.FindTrailerCurrentLoadByCableType, strCableType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Find Trailer Current Load By Cable Type " + Ex.Message);
            }

            return aFindTrailerCurrentLoadByCableTypeDataSet;
        }
        public FindSortedTrailerCurrentLoadDataSet FindSortedTrailerCurrentLoad()
        {
            try
            {
                aFindSortedTrailerCurrentLoadDataSet = new FindSortedTrailerCurrentLoadDataSet();
                aFindSortedTrailerCurrentLoadTableAdapter = new FindSortedTrailerCurrentLoadDataSetTableAdapters.FindSortedTrailerCurrentLoadTableAdapter();
                aFindSortedTrailerCurrentLoadTableAdapter.Fill(aFindSortedTrailerCurrentLoadDataSet.FindSortedTrailerCurrentLoad);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Find Sorted Trailer Current Load " + Ex.Message);
            }

            return aFindSortedTrailerCurrentLoadDataSet;
        }
        public bool UpdateTrailerCurrentLoadFootage(int intTrailerID, int intCurrentFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerCurrentLoadFootageTableAdapter = new UpdateTrailerCurrentLoadFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerCurrentLoadFootageTableAdapter.UpdateTrailerCurrentLoadFootage(intTrailerID, intCurrentFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Update Trailer Current Load Footage " + Ex.Message);
            }

            return blnFatalError;
        }
        public bool UpdateTrailerCurrentLoad(int intTrailerID, int intPartID, string strReelNumber, int intCurrentFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateTrailerCurrentLoadTableAdapter = new UpdateTrailerCurrentLoadEntryTableAdapters.QueriesTableAdapter();
                aUpdateTrailerCurrentLoadTableAdapter.UpdateTrailerCurrentLoad(intTrailerID, intPartID, strReelNumber, intCurrentFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Update Trailer Current Load " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertTrailerCurrentLoad(int intTrailerID, int intPartID, string strReelNumber, int intCurrentFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertTrailerCurrentLoadTableAdapter = new InsertTrailerCurrentLoadEntryTableAdapters.QueriesTableAdapter();
                aInsertTrailerCurrentLoadTableAdapter.InsertTrailerCurrentLoad(intTrailerID, intPartID, strReelNumber, intCurrentFootage);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Insert Trailer Current Load " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public TrailerCurrentLoadDataSet GetTrailerCurrentLoadInfo()
        {
            try
            {
                aTrailerCurrentLoadDataSet = new TrailerCurrentLoadDataSet();
                aTrailerCurrentLoadTableAdapter = new TrailerCurrentLoadDataSetTableAdapters.trailercurrentloadTableAdapter();
                aTrailerCurrentLoadTableAdapter.Fill(aTrailerCurrentLoadDataSet.trailercurrentload);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Get Trailer Current Load Info " + Ex.Message);
            }

            return aTrailerCurrentLoadDataSet;
        }
        public void UpdateTrailerCurrentLoadDB(TrailerCurrentLoadDataSet aTrailerCurrentLoadDataSet)
        {
            try
            {
                aTrailerCurrentLoadTableAdapter = new TrailerCurrentLoadDataSetTableAdapters.trailercurrentloadTableAdapter();
                aTrailerCurrentLoadTableAdapter.Update(aTrailerCurrentLoadDataSet.trailercurrentload);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Trailer Current Load Class // Update Trailer Current Load DB " + Ex.Message);
            }
        }
    }
}
