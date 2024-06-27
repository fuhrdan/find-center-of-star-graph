//*****************************************************************************
//** 1791. Find Center of Star Graph leetcode                                **
//** I saw a leetcode challenge and was shocked to see a hash table would be **
//** a fast way to solve the problem.  leetcode is making me a better        **
//** programmer at solving problems.                                         **
//** Either way, this was a fun fast problem.   --Dan                        **
//*****************************************************************************

int findCenter(int** edges, int edgesSize, int* edgesColSize) {
    int retNum = 0;
    int center = 0;
    int hash[100001] = {0};
    for(int i = 0; i < edgesSize; i++)
    {
        for(int j = 0; j < edgesColSize[i]; j++)
        {
            hash[edges[i][j]]++;
            if (retNum < hash[edges[i][j]])
            {
                retNum = hash[edges[i][j]];
                center = edges[i][j];
            }
        }
//        printf("edges[%d][0] = %d edgesColSize[%d] = %d\n",i,edges[i][0],i,edgesColSize[i]);
    }
    return center;
}