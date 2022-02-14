class Solution {
    public void rotate(List<List<int>> a) {
        int N = a.Count();
        a = TransposeMatrix(a);
        for(int i  =0 ; i < N; i++){
            a[i] = ReverseArray(a[i], 0, N-1);
        }
    }

    public List<List<int>> TransposeMatrix(List<List<int>> A){
        int N = A.Count();
        for(int i = 0; i < N; i++){
            List<int> inner = new List<int>();
            for(int j = i+1; j < N; j++){
                int temp = A[i][j];
                A[i][j] = A[j][i];
                A[j][i] = temp;
            }
        }
        return A;
    }

    public List<int> ReverseArray(List<int> A, int s, int e){
        while(s < e){
            int temp = A[s];
            A[s] =  A[e];
            A[e] = temp;
            s++;
            e--;
        }
        return A;
    }
}
