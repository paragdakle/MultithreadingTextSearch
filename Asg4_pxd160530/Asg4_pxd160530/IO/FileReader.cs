using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg4_pxd160530.IO
{
    /// <remarks>
    /// Author: Parag Pravin Dakle
    /// Course: Human Computer Interaction CS 6326 Spring 2017
    /// Net ID: pxd160530
    /// </remarks>
    /// <summary>
    /// <c>class FileReader</c>
    /// This class carries out direct file reading operations using the <c>StreamReader</c> class.
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// filePath: The path of the file, which includes name, to perform read operations on.
        /// fileSize: The size of the file in bytes.
        /// stream: The StreamReader object.
        /// </summary>
        string filePath { get; }

        public long fileSize { get; set; }

        StreamReader stream;

        /// <summary>
        /// Class Constructor.
        /// Initializes filePath to the provided filePath parameter and stream to null.
        /// </summary>
        /// <param name="filePath">The path of the file which includes name.</param>
        public FileReader(string filePath)
        {
            this.filePath = filePath;
            this.fileSize = 0;
            this.stream = null;
        }

        /// <summary>
        /// The function opens a file by creating a new StreamReader object with the file pointed by filePath.
        /// </summary>
        /// <returns>True if file was opened successfully else False.</returns>
        public bool openFile()
        {
            if (stream == null)
            {
                try
                {
                    stream = new StreamReader(filePath, Encoding.ASCII);
                    fileSize = new FileInfo(filePath).Length;
                }
                catch (IOException e)
                {
                    Console.Out.WriteLine(e.StackTrace);
                    stream = null;
                }
            }
            else
            {
                Console.Out.WriteLine("Error another file already open");
            }
            return stream != null;
        }

        /// <summary>
        /// The function closes the file who's handle is present in stream object.
        /// Also disposes the stream object cleanly.
        /// </summary>
        /// <returns>True if file was closed successfully else False.</returns>
        public bool closeFile()
        {
            if (stream != null)
            {
                stream.Close();
                ((IDisposable)stream).Dispose();
                stream = null;
                return true;
            }
            return false;
        }

        /// <summary>
        /// The function reads a line from a file.
        /// </summary>
        /// <returns>A line from the file as a string object if the read operation was successful else null</returns>
        /// <remarks>
        /// If the stream object does not contain handle to a file a <c>FileNotFoundException</c>
        /// </remarks>
        public string readFromFile()
        {
            if (stream == null)
            {
                throw new FileNotFoundException();
            }
            try
            {
                return stream.ReadLine();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.StackTrace);
                return null;
            }
        }
    }
}
