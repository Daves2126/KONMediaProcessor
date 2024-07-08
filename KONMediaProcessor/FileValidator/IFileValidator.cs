﻿namespace KONMediaProcessor.FileValidator;

using Exceptions;

/// <summary>
/// Interface for validating files and directories.
/// </summary>
public interface IFileValidator
{
    /// <summary>
    /// Checks if the specified file exists.
    /// </summary>
    /// <param name="filePath">The path of the file to check.</param>
    /// <returns>True if the file exists, otherwise false.</returns>
    bool FileExists(string filePath);

    /// <summary>
    /// Ensures that the specified directory exists. If it does not exist, creates it.
    /// </summary>
    /// <param name="directoryPath">The path of the directory to check or create.</param>
    /// <exception cref="UnauthorizedAccessException">Thrown when the application does not have sufficient permissions to create the directory.</exception>
    void EnsureDirectoryExists(string directoryPath);

    /// <summary>
    /// Ensures that the directory for the specified file path exists. If it does not exist, creates it.
    /// </summary>
    /// <param name="filePath">The file path for which to ensure the directory exists.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="filePath"/> is null or empty, or when the directory path is null.</exception>
    /// <exception cref="UnauthorizedAccessException">Thrown when the application does not have sufficient permissions to create the directory.</exception>
    /// <exception cref="DirectoryNotFoundException">Thrown when the directory does not exist and cannot be created.</exception>
    void EnsureDirectoryPathExists(string filePath);

    /// <summary>
    /// Validates the specified input file paths and output file path.
    /// </summary>
    /// <param name="inputs">The input file paths to validate.</param>
    /// <param name="output">The output file path to validate.</param>
    /// <param name="overrideFile">Whether to allow overriding the output file if it exists.</param>
    /// <exception cref="ArgumentNullException">Thrown when any of the input file paths or the output file path is null or empty.</exception>
    /// <exception cref="InputAndOutputFileSameException">Thrown when an input file is the same as the output file.</exception>
    /// <exception cref="FileNotFoundException">Thrown when an input file does not exist.</exception>
    /// <exception cref="FileAlreadyExistsException">Thrown when the output file exists and <paramref name="overrideFile"/> is false.</exception>
    /// <exception cref="UnauthorizedAccessException">Thrown when the application does not have sufficient permissions to access or create directories.</exception>
    /// <exception cref="DirectoryNotFoundException">Thrown when the directory for the output file does not exist and cannot be created.</exception>
    void ValidatePaths(string[] inputs, string output, bool overrideFile);
}