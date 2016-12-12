#include "FunctionReservoir.h"
#include "Reservoir.h"
#include <iostream>
#include <fstream>
#include <string>


FunctionReservoir::FunctionReservoir()
{
	count = 0;
	r = new Reservoir[count];
}
void FunctionReservoir::FillReservoir()
{
	cout << "Enter counter of reservoir: ";
	cin >> count;
	r = new Reservoir[count];
	for (int i = 0; i < count; i++)
	{
		r[i].FillReservoir();
	}
	cout << endl;
}
void FunctionReservoir::AddReservoir()
{
	Reservoir *tmp = new Reservoir[count + 1];
	for (int i = 0; i < count; i++)
	{
		tmp[i] = r[i];
	}
	tmp[count].FillReservoir();
	r = tmp;
	count++;
	cout << endl;
}
void FunctionReservoir::ShowReservoir()
{
	for (int i = 0; i < count; i++)
	{
		r[i].Show();
	}
	cout << endl;
}
void FunctionReservoir::Volume()
{
	int number;
	cout << "Enter number of reservoir: ";
	cin >> number;
	number--;
	for (int i = number; i < count; i++)
	{
		r[i].EstimationVolume();
	}
	cout << endl;
}
void FunctionReservoir::Area1() 
{
	int number;
	cout << "Enter number of reservoir: ";
	cin >> number;
	number--;
	for (int i = number; i < count; i++)
	{
		r[i].Area();
	}
	cout << endl;
}
void FunctionReservoir::Comparison() 
{
	char *k = new char[50];
	int number;
	cout << "Enter type which you want to comparison on type of reservoir: ";
	cin >> k;
	cout << "Enter number of reservoir if you want to comparison: ";
	cin >> number;
	number--;
	cout << endl;
	cout << "Name of reservoir: " << endl << " Type of reservoir: " << endl << "Width: " << endl << "Length: " << endl << "Max Depth: " << endl;
	for (int i = number; i < count; i++)
	{
		if (strcmp(r[i].type, (k)) == 0)
		{
			r[i].Show();
			cout << "This water belongs to the specified type" << endl;
		}
	}
	for (int i = number; i < count; i++)
	{
		if (strcmp(r[i].type, (k)) != 0)
		{
			cout << " " << endl;
		}
	}
	cout << endl;

}
void FunctionReservoir::ComparisonArea()
{
	// create temporary arrays: 1) with unique types name; 2) with reservoir -> type indexes
	int types_count = 0;
	char** types = new char*[count];
	int* types_index_map = new int[count];
	for (int i = 0; i < count; i++)
	{
		bool found = false;
		for (int ii = 0; ii < types_count; ii++)
		{
			if (strcmp(r[i].type, types[ii]) == 0)
			{
				found = true;
				types_index_map[i] = ii;
				break;
			}
		}
		if (!found)
		{
			types_index_map[i] = types_count;
			types[types_count++] = r[i].type;
		}
	}

	// find a biggest area for each type
	double* max_areas = new double[types_count];
	for (int i = 0; i < types_count; i++)
		max_areas[i] = -1;
	for (int i = 0; i < count; i++)
	{
		int type_idx = types_index_map[i];
		double area = r[i].Area();
		if (area > max_areas[type_idx])
			max_areas[type_idx] = area;
	}

	// show the biggest areas for each type
	for (int i = 0; i < types_count; i++)
	{
		cout << "Reservoir type: " << types[i] << ";";
		cout << " The biggest area is " << max_areas[i] << endl;
	}

	// delete the temporary arrays
	delete[] types;
	delete[] types_index_map;
	delete[] max_areas;
}
void FunctionReservoir::SaveInfoFile()
{

	string str;
	ifstream file("Reservoir.txt", ios::in);

	cout << "Name of reservoir " << endl << " Type of reservoir" << endl << "Width" << endl << "Length" << endl << "MaxDepth" << "\n";
	while (!file.eof())
	{
		getline(file, str);
		cout << str << endl;
	}
	file.close();

}
void FunctionReservoir::InfoinFile()
{
	string a;
	ofstream fout("Reservoir.txt", ios::app | ios::out | ios::ate);

	for (int i = 0; i < count; i++)
	{
		fout << endl << endl;
		fout << r[i].Name << endl << r[i].type << endl << r[i].Width << endl << r[i].Length << endl << r[i].MaxDepth << endl;
	}

	cout << endl;
	fout.close();
	cout << "Data saved" << endl;
}


