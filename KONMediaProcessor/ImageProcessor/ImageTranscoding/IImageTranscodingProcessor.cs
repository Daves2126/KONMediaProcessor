﻿namespace KONMediaProcessor.ImageProcessor.ImageTranscoding;

using Domain.ImageInfo;

/// <summary>
/// Provides methods to create or modify images
/// </summary>
public interface IImageTranscodingProcessor
{
    /// <summary>
    /// Generates an image with specified text data overlaid.
    /// </summary>
    /// <param name="textDataList">List of text data to overlay on the image.</param>
    /// <param name="font">Font path to be used for the text.</param>
    /// <param name="textColor">Color of the text.</param>
    /// <param name="backgroundColor">Background color of the image.</param>
    /// <param name="width">Width of the generated image.</param>
    /// <param name="height">Height of the generated image.</param>
    /// <param name="fontSize">Font size of the text.</param>
    /// <param name="outputFilePath">File path for the generated image.</param>
    /// <param name="overrideFile">Flag indicating whether to override the file if it already exists.</param>
    void GenerateImage(List<TextData> textDataList, string fontPath, string textColor, string backgroundColor, int width, int height, int fontSize, string outputFilePath, bool overrideFile = false);

    /// <summary>
    /// Combines multiple images into a single image with specified dimensions and background color.
    /// </summary>
    /// <param name="imageDataList">List of image data specifying images to combine and their positions.</param>
    /// <param name="width">Width of the combined image.</param>
    /// <param name="height">Height of the combined image.</param>
    /// <param name="outputFilePath">File path for the combined image.</param>
    /// <param name="backgroundColor">Background color of the combined image.</param>
    /// <param name="overrideFile">Flag indicating whether to override the file if it already exists.</param>
    void CombineImages(List<ImageData> imageDataList, int width, int height, string outputFilePath, string backgroundColor, bool overrideFile = false);

    /// <summary>
    /// Resizes an image to specified dimensions.
    /// </summary>
    /// <param name="inputFilePath">File path of the input image.</param>
    /// <param name="newWidth">New width of the image.</param>
    /// <param name="newHeight">New height of the image.</param>
    /// <param name="outputFilePath">File path for the resized image.</param>
    /// <param name="overrideFile">Flag indicating whether to override the file if it already exists.</param>
    void ResizeImage(string inputFilePath, int newWidth, int newHeight, string outputFilePath, bool overrideFile = false);

    /// <summary>
    /// Converts an image to a video with specified dimensions and duration.
    /// </summary>
    /// <param name="inputFilePath">File path of the input image.</param>
    /// <param name="durationInSeconds">Duration of the video in seconds.</param>
    /// <param name="width">Width of the video.</param>
    /// <param name="height">Height of the video.</param>
    /// <param name="outputFilePath">File path for the generated video.</param>
    /// <param name="overrideFile">Flag indicating whether to override the file if it already exists.</param>
    void ConvertImageToVideo(string inputFilePath, int durationInSeconds, int width, int height, string outputFilePath, bool overrideFile = false);

    /// <summary>
    /// Converts an image to a video with specified duration.
    /// The method automatically adjusts the image dimensions to be divisible by 2.
    /// </summary>
    /// <param name="inputFilePath">File path of the input image.</param>
    /// <param name="durationInSeconds">Duration of the video in seconds.</param>
    /// <param name="outputFilePath">File path for the generated video.</param>
    /// <param name="overrideFile">Flag indicating whether to override the file if it already exists.</param>
    void ConvertImageToVideo(string inputFilePath, int durationInSeconds, string outputFilePath, bool overrideFile = false);
}
