//Matthew Dadoun - 100662523
#include "AssignmentClass.h"
#include <fstream>
#include <iostream>
#include <cstring>
#include <sstream>
#include <string>
void AssignmentClass::saveCoordinates(char object, float x, float y, float z)
{
	outfile.open("savedLevel.txt", std::ios_base::app);
	outfile <<object<<"\n"<< x << "\n" << y << "\n" << z<<"\n";
	outfile.close(); 
	offset += 4;
}

void AssignmentClass::overwriteCoordinates()
{
	std::ofstream ofs;
	ofs.open("savedLevel.txt", std::ofstream::out | std::ofstream::trunc);
	offset = 0;
	ofs.close();
}

float AssignmentClass::LoadCoordinateX()
{
	infile.open("savedLevel.txt");
	std::string finalX;
	for (int i = 0; i <= offset; i++)
	{
		std::getline(infile, finalX);
	}
	std::getline(infile, finalX);
	float f = std::strtof(finalX.c_str(), nullptr);
	savedX = f;
	infile.close();
	return savedX;
}

float AssignmentClass::LoadCoordinateY()
{
	infile.open("savedLevel.txt");
	std::string finalY;
	for (int i = 0; i <= offset+1; i++)
	{
		std::getline(infile, finalY);
	}
	std::getline(infile, finalY);
	float f = std::strtof(finalY.c_str(), nullptr);
	savedY = f;
	infile.close();
	return savedY;
}

float AssignmentClass::LoadCoordinateZ()
{
	infile.open("savedLevel.txt");
	std::string finalZ;
	float f;
	for (int i = 0; i <= offset + 2; i++)
	{
		std::getline(infile, finalZ);
	}
	infile.close();
	return savedZ;
}

